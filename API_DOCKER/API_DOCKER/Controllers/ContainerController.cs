using API_DOCKER.Models;
using API_DOCKER.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace API_DOCKER.Controllers
{
    [ApiController]
    [System.Web.Http.RoutePrefix("api/containers")]
    public class ContainerController : ApiController
    {
        static HttpClient client = new HttpClient();

        public ContainerController()
        {
            client = new HttpClient();
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
            HttpResponseMessage response = await client.GetAsync("/containers/json?all=true");

            if (response.IsSuccessStatusCode)
            {
                responseString = await response.Content.ReadAsStringAsync();
            }

            return responseString;
        }

        [System.Web.Http.AcceptVerbs("POST")]
        [System.Web.Http.Route("create")]
        public async Task<string> Create(ContainerDTO containerDTO)
        {
            string responseString = string.Empty;
            string exposedPort = containerDTO.Port + "/tcp";

            var bodyString = @"{ ""Image"": ""ubuntu: 18.04"", ""ExposedPorts"": {"""  + exposedPort + @""": {} } , ""HostConfig"" : { ""PortBindings"" : { """  + exposedPort + @""": [{ ""HostPort"": """ + containerDTO.Port + @""" }] } , ""RestartPolicy"": { ""Name"": ""always"" } } }";
          
            var jsonData = JsonConvert.SerializeObject(bodyString);
            
            var buffer = System.Text.Encoding.UTF8.GetBytes(jsonData);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");

            HttpResponseMessage response = await client.PostAsync($"/containers/create?name={containerDTO.Name}", byteContent);

            if (response.IsSuccessStatusCode)
            {
                responseString = await response.Content.ReadAsStringAsync();
            }

            return responseString;
        }

        [System.Web.Http.AcceptVerbs("DELETE")]
        [System.Web.Http.Route("delete/{id}")]
        public async Task<string> DeleteById(string id)
        {
            string responseString = string.Empty;
            HttpResponseMessage response = await client.DeleteAsync($"/containers/{id}");

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

            HttpResponseMessage response = await client.PostAsync("/containers/prune", null);

            if (response.IsSuccessStatusCode)
            {
                responseString = await response.Content.ReadAsStringAsync();
            }

            return responseString;
        }

    }
}