using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_DOCKER.Models
{
    public class ContainerDTO
    {
        public string Image { get; set; }
        public string Port { get; set; }
        public string Name { get; set; }
    }

}