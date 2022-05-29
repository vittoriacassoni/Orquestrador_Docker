using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRONT_APP_DOCKER
{
    public partial class Form1 : Form
    {
        public const string URL_API = "https://localhost:44328/";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListImages_Click(object sender, EventArgs e)
        {
            lblImages.Text = "";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL_API);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/images/list").Result;
            if (response.IsSuccessStatusCode)
            {
                lblImages.Text = response.Content.ReadAsStringAsync().Result;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnListContainers_Click(object sender, EventArgs e)
        {
            lblContainers.Text = "";

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL_API);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/containers/list").Result;
            if (response.IsSuccessStatusCode)
            {
                lblContainers.Text = response.Content.ReadAsStringAsync().Result;                
            }
        }

        private void btnCreateContainer_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL_API);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/containers/list").Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Criado");
            }
        }

        private void btnDeleteImagesAll_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL_API);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.DeleteAsync("api/images/delete").Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Deletado");
            }
        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL_API);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.DeleteAsync("api/images/delete").Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Deletado");
            }
        }

        private void btnCreateImage_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL_API);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("api/images/list").Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Criado");
            }
        }

        private void btnDeleteImageAll_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL_API);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.DeleteAsync("api/containers/delete").Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Deletado");
            }
        }

        private void btnDeleteContainer_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL_API);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.DeleteAsync($"api/containers/delete/{txtId.Text}").Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Deletado");
            }
        }
    }
}
