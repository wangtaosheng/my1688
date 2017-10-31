using com.alibaba.openapi.client.entity;
using com.alibaba.openapi.client.http;
using com.alibaba.openapi.client.policy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace com.alibaba.openapi.client
{
    public class SyncAPIClient
    {
        private ClientPolicy clientPolicy;

        public SyncAPIClient(ClientPolicy clientPolicy)
        {
            this.clientPolicy = clientPolicy;
        }
        public string sendJson(Request request)
        {
            HttpClient httpClient = new HttpClient(clientPolicy);
            string result = httpClient.requestJson(request, request.RequestPolicyInstance, null);
            return result;
        }
        public T send<T>(Request request)
        {
            HttpClient httpClient = new HttpClient(clientPolicy);
            T result = httpClient.request<T>(request, request.RequestPolicyInstance, null);
            return result;
        }

        public T send<T>(Request request, String accessToken)
        {
            HttpClient httpClient = new HttpClient(clientPolicy);
            T result = httpClient.request<T>(request, request.RequestPolicyInstance, accessToken);
            return result;
        }

        public AuthorizationToken getToken(String code)
        {

            GetTokenRequest request = new GetTokenRequest();
            request.setCode(code);
            request.setGrant_type("authorization_code");
            request.setNeed_refresh_token(true);
            request.setClient_id(clientPolicy.AppKey);
            request.setClient_secret(clientPolicy.SecretKey);

            return this.send<AuthorizationToken>(request);
        }

        public AuthorizationToken refreshToken(String refreshToken)
        {

            RefreshTokenRequest request = new RefreshTokenRequest();
            request.setRefreshToken(refreshToken);
            request.setGrant_type("refresh_token");
            request.setClient_id(clientPolicy.AppKey);
            request.setClient_secret(clientPolicy.SecretKey);
            return this.send<AuthorizationToken>(request);

        }
    }
}

