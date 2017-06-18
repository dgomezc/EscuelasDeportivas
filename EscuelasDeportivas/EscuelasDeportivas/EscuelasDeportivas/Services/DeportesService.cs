using EscuelasDeportivas.Configurations;
using EscuelasDeportivas.Models;
using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelasDeportivas.Services
{
    public class DeportesService
    {
        private MobileServiceClient _client;
        private IMobileServiceTable<Deporte> _deporteItemTable;
        private static DeportesService _instance;

        public static DeportesService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DeportesService();
                }

                return _instance;
            }
        }

        private DeportesService()
        {
            if (_client != null)
                return;

            _client = new MobileServiceClient(GlobalSettings.AzureEndpoint);
            _deporteItemTable = _client.GetTable<Deporte>();
        }

        public async Task<IEnumerable<Deporte>> ReadDeportesAsync()
        {
            return await _deporteItemTable.ReadAsync();
        }
    }
}
