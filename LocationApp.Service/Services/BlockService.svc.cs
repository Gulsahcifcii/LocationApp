using LocationApp.Data.Dto;
using LocationApp.Service.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LocationApp.Service.Services
{
    public class BlockService : IBlockService
    {
        private Core.Core.BlockLogic blockLogic = new Core.Core.BlockLogic();
        public string AddBlock(int blockID, int buildID, string name, string gps)
        {
            var result = blockLogic.AddBlock(new BlockDto
            {
                BlockID = blockID,
                BuildID = buildID,
                Name = name,
                Gps = gps
            });
            return JsonConvert.SerializeObject(result);
        }
        public string DeleteBlock(int blockID)
        {
            var result = blockLogic.DelBlock(blockID);
            return JsonConvert.SerializeObject(result);
        }
        public string GetBlock(int blockID)
        {
            var result = blockLogic.GetBlock(blockID);
            return JsonConvert.SerializeObject(result);
        }
        public string UpdateBlock(int blockID, int buildID, string name, string gps)
        {
            var result = blockLogic.SetBlock(new BlockDto
            {
                BlockID = blockID,
                BuildID = buildID,
                Name = name,
                Gps = gps
            });
            return JsonConvert.SerializeObject(result);
        }
    }
}
