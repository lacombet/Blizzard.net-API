﻿
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Web;

namespace WOWSharp.Community.SilverlightProxy
{
	/// <summary>
	///   An HTTP handler to route silverlight requests to battle.net sites
	/// </summary>
	public class ApiRequestRouter : IHttpHandler
    {
        /// <summary>
        ///   Region name HTTP header
        /// </summary>
        private const string RegionNameHttpHeader = "X-WOWSharpProxy-Region";

        /// <summary>
        ///   Url HTTP header
        /// </summary>
        private const string ApiUrlHttpHeader = "X-WOWSharpProxy-Url";

        /// <summary>
        ///   Locale HTTP header
        /// </summary>
        private const string LocaleHttpHeader = "X-WOWSharpProxy-Locale";

        #region IHttpHandler Members

        /// <summary>
        ///   There is no resources allocated by this handler, so it's safe to reuse
        /// </summary>
        public virtual bool IsReusable
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        ///   Routes a request to battle.net community site
        /// </summary>
        /// <param name="context"> HttpContext </param>
        public virtual void ProcessRequest(HttpContext context)
        {
            // Region name
            string regionName = context.Request.Headers[RegionNameHttpHeader];
            if (string.IsNullOrEmpty(regionName))
            {
                Error(context,
                      string.Format(CultureInfo.InvariantCulture, ErrorMessages.HeaderMissing, RegionNameHttpHeader));
                return;
            }

            Region region =
                Region.AllRegions.FirstOrDefault(
                    r => string.Equals(r.Name, regionName, StringComparison.OrdinalIgnoreCase));
            if (region == null)
            {
                Error(context,
                      string.Format(CultureInfo.InvariantCulture, ErrorMessages.InvalidRegion, RegionNameHttpHeader));
                return;
            }

            // Url (Required)
            string url = context.Request.Headers[ApiUrlHttpHeader];
            if (string.IsNullOrEmpty(url))
            {
                Error(context,
                      string.Format(CultureInfo.InvariantCulture, ErrorMessages.HeaderMissing, ApiUrlHttpHeader));
                return;
            }

            // Locale (Not required)
            string locale =
                region.GetSupportedLocale(context.Request.Headers[LocaleHttpHeader]).Replace('-', '_');

            var uri = new Uri("http://" + region.Host + url);
            uri = !string.IsNullOrEmpty(uri.Query)
                      ? new Uri(uri + "&locale=" + locale)
                      : new Uri(uri + "?locale=" + locale);

            // Create the request
            var request = (HttpWebRequest) WebRequest.Create(uri);

			uri = !string.IsNullOrEmpty(uri.Query)
							  ? new Uri(uri + "&apikey=" + GetApiKey())
							  : new Uri(uri + "?apikey=" + GetApiKey());

			request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;


            HttpWebResponse response = null;
            try
            {
                response = (HttpWebResponse) request.GetResponse();
                ReturnResponse(context, response);
            }
            catch (WebException ex)
            {
                response = (HttpWebResponse) ex.Response;
                if (ex.Status == WebExceptionStatus.ProtocolError)
                    ReturnResponse(context, response);
                else
                    Error(context, ex.Message);
            }
            finally
            {
                if (response != null)
                    response.Close();
            }
        }

        #endregion

        /// <summary>
        ///   Returns a routing error to the silverlight client
        /// </summary>
        /// <param name="context"> Http Context </param>
        /// <param name="errorDescription"> Error message </param>
        public void Error(HttpContext context, string errorDescription)
        {
            context.Response.StatusCode = 500;
            context.Response.StatusDescription = "Proxy Error";
            var error = new ApiError("nok", errorDescription);
            var serializer = new DataContractJsonSerializer(typeof (ApiError));
            serializer.WriteObject(context.Response.OutputStream, error);
        }

        /// <summary>
        ///   Returns the response from battle.net as it is
        /// </summary>
        /// <param name="context"> Http Context </param>
        /// <param name="response"> the battle.net site response </param>
        public void ReturnResponse(HttpContext context, HttpWebResponse response)
        {
            context.Response.StatusCode = (int) response.StatusCode;
            context.Response.StatusDescription = response.StatusDescription;
            var buffer = new byte[32*1024];
            using (Stream stream = response.GetResponseStream())
            {
                int length;
                while (stream != null && (length = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    context.Response.OutputStream.Write(buffer, 0, length);
                }
            }
        }

        /// <summary>
        ///   When overriden gets the API key.
        /// </summary>
        /// <returns> Returns the API key used to get the request </returns>
        public virtual string GetApiKey()
        {
            // I rather not implement it here 
            // It's up to the application to determine how to secure the keys
            return null;
        }
    }
}