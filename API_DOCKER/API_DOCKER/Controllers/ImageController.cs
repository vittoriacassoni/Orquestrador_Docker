using API_DOCKER.Utils;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace API_DOCKER.Controllers
{
    [ApiController]
    [System.Web.Http.RoutePrefix("api/images")]
    public class ImageController : ApiController
    {
        static HttpClient client = new HttpClient();

        public ImageController()
        {
            client.BaseAddress = new Uri(Constants.Route_Base_Docker);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        [System.Web.Http.AcceptVerbs("GET")]
        [System.Web.Http.Route("list")]
        public async Task<string> List()
        {
            string responseString = string.Empty;
            HttpResponseMessage response = await client.GetAsync("/images/json?all=true");

            if (response.IsSuccessStatusCode)
            {
                responseString = await response.Content.ReadAsStringAsync();
            }

            return responseString;
        }

        [System.Web.Http.AcceptVerbs("POST")]
        [System.Web.Http.Route("create")]
        public async Task<string> Create()
        {
            string responseString = string.Empty;
            HttpResponseMessage response = await client.PostAsync("/images/create", null);

            if (response.IsSuccessStatusCode)
            {
                responseString = await response.Content.ReadAsStringAsync();
            }

            return responseString;
        }

        [System.Web.Http.AcceptVerbs("DELETE")]
        [System.Web.Http.Route("delete/{id}")]
        public async Task<string> DeleteByName(string id)
        {
            string responseString = string.Empty;
            HttpResponseMessage response = await client.DeleteAsync($"/images/{id}?force=true");

            if (response.IsSuccessStatusCode)
            {
                responseString = await response.Content.ReadAsStringAsync();
            }

            return responseString;
        }

        [System.Web.Http.AcceptVerbs("DELETE")]
        [System.Web.Http.Route("delete")]
        public async Task<string> Delete()
        {
            string responseString = string.Empty;
            HttpResponseMessage response = await client.GetAsync("/images/json");

            if (response.IsSuccessStatusCode)
            {
                responseString = await response.Content.ReadAsStringAsync();
            }

            return responseString;
        }

    }
}