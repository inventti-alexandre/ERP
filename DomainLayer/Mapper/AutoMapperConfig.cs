using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using AutoMapper;

namespace DomainLayer.Mapper
{
    public static class AutoMapperConfig
    {

        private static bool _configed = false;


        public static void InstallMap()
        {
            if (!_configed)
            {


                _configed = true;
            }
        }


        public static bool IsConfig()
        {
            return _configed;
        }


    }
}
