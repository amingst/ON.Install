// <copyright file="OnBoardingController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace FortisAPI.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using FortisAPI.Standard;
    using FortisAPI.Standard.Authentication;
    using FortisAPI.Standard.Exceptions;
    using FortisAPI.Standard.Http.Client;
    using FortisAPI.Standard.Http.Request;
    using FortisAPI.Standard.Http.Request.Configuration;
    using FortisAPI.Standard.Http.Response;
    using FortisAPI.Standard.Utilities;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// OnBoardingController.
    /// </summary>
    public class OnBoardingController : BaseController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OnBoardingController"/> class.
        /// </summary>
        /// <param name="config"> config instance. </param>
        /// <param name="httpClient"> httpClient. </param>
        /// <param name="authManagers"> authManager. </param>
        /// <param name="httpCallBack"> httpCallBack. </param>
        internal OnBoardingController(IConfiguration config, IHttpClient httpClient, IDictionary<string, IAuthManager> authManagers, HttpCallBack httpCallBack = null)
            : base(config, httpClient, authManagers, httpCallBack)
        {
        }

        /// <summary>
        /// This method can be used to pre-populate data on the Merchant Processing Application (MPA), a form that prospective merchants must complete and sign prior to approval. Using this method will reduce the effort required by the merchant at boarding time, in scenarios where data about the prospective merchant has already been collected. This method will return an Application ID, which can be sent to a prospective merchant to obtain and complete the pre-filled application.
        /// Properties that are marked "Required" indicate the minimum required data for creating and saving an MPA. When using this method, you must provide data for each "Required" property, or you will not receive an Application ID. Properties that are marked "Required for completion" are those which need to be provided to Fortis before the Merchant Processing Application can be approved. These properties may be omitted or left blank when using this method, however, the merchant will be required to provide this data before the application can be submitted. Properties that are marked "Conditionally Required" may be required for completion of the Merchant Processing Application, depending on the values provided for other fields. See the description for each of these properties for more information about their requirement criteria.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <returns>Returns the Models.ResponseOnboarding response from the API call.</returns>
        public Models.ResponseOnboarding MerchantBoarding(
                Models.V1OnboardingRequest body)
        {
            Task<Models.ResponseOnboarding> t = this.MerchantBoardingAsync(body);
            ApiHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// This method can be used to pre-populate data on the Merchant Processing Application (MPA), a form that prospective merchants must complete and sign prior to approval. Using this method will reduce the effort required by the merchant at boarding time, in scenarios where data about the prospective merchant has already been collected. This method will return an Application ID, which can be sent to a prospective merchant to obtain and complete the pre-filled application.
        /// Properties that are marked "Required" indicate the minimum required data for creating and saving an MPA. When using this method, you must provide data for each "Required" property, or you will not receive an Application ID. Properties that are marked "Required for completion" are those which need to be provided to Fortis before the Merchant Processing Application can be approved. These properties may be omitted or left blank when using this method, however, the merchant will be required to provide this data before the application can be submitted. Properties that are marked "Conditionally Required" may be required for completion of the Merchant Processing Application, depending on the values provided for other fields. See the description for each of these properties for more information about their requirement criteria.
        /// </summary>
        /// <param name="body">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ResponseOnboarding response from the API call.</returns>
        public async Task<Models.ResponseOnboarding> MerchantBoardingAsync(
                Models.V1OnboardingRequest body,
                CancellationToken cancellationToken = default)
        {
            // the base uri for api requests.
            string baseUri = this.Config.GetBaseUri();

            // prepare query string for API call.
            StringBuilder queryBuilder = new StringBuilder(baseUri);
            queryBuilder.Append("/v1/onboarding");

            // append request with appropriate headers and parameters
            var headers = new Dictionary<string, string>()
            {
                { "user-agent", this.UserAgent },
                { "accept", "application/json" },
                { "Content-Type", "application/json" },
            };

            // append body params.
            var bodyText = ApiHelper.JsonSerialize(body);

            // prepare the API call request to fetch the response.
            HttpRequest httpRequest = this.GetClientInstance().PostBody(queryBuilder.ToString(), headers, bodyText);

            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnBeforeHttpRequestEventHandler(this.GetClientInstance(), httpRequest);
            }

            httpRequest = await this.AuthManagers["global"].ApplyAsync(httpRequest).ConfigureAwait(false);

            // invoke request and get response.
            HttpStringResponse response = await this.GetClientInstance().ExecuteAsStringAsync(httpRequest, cancellationToken: cancellationToken).ConfigureAwait(false);
            HttpContext context = new HttpContext(httpRequest, response);
            if (this.HttpCallBack != null)
            {
                this.HttpCallBack.OnAfterHttpResponseEventHandler(this.GetClientInstance(), response);
            }

            if (response.StatusCode == 401)
            {
                throw new Response401tokenException("Unauthorized", context);
            }

            if (response.StatusCode == 412)
            {
                throw new Response412Exception("Precondition Failed", context);
            }

            // handle errors defined at the API level.
            this.ValidateResponse(response, context);

            return ApiHelper.JsonDeserialize<Models.ResponseOnboarding>(response.Body);
        }
    }
}