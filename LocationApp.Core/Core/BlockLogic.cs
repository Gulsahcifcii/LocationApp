using LocationApp.Data.Database;
using LocationApp.Data.Dto;
using LocationApp.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace LocationApp.Core.Core
{
    public class BlockLogic
    {
        public string AddBlock(BlockDto blockDto)
        {
            try
            {
                if (isThere(blockDto))
                {
                    return (HttpStatusCode.InternalServerError).ToString();
                }

                block item = new block();
                item.BlockID = blockDto.BlockID;
                item.BuildID = blockDto.BlockID;
                item.Name = blockDto.Name;
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.GetRepository<block>().Insert(item);
                    unitOfWork.saveChanges();
                    return (HttpStatusCode.OK).ToString();
                }

            }
            catch (Exception ex)
            {
                return (HttpStatusCode.InternalServerError).ToString();
            }
        }
        public string SetBlock(BlockDto blockDto)
        {
            try
            {
                block item = new block();
                item.BlockID = blockDto.BlockID;
                item.BuildID = blockDto.BlockID;
                item.Name = blockDto.Name;
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.GetRepository<block>().Update(item);
                    unitOfWork.saveChanges();
                    return (HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception ex)
            {
                return (HttpStatusCode.InternalServerError).ToString();
            }
        }
        public string DelBlock(int blockID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    var selectedBlock = unitofWork.GetRepository<block>().GetById(x => x.BlockID == blockID);
                    unitofWork.GetRepository<block>().Delete(selectedBlock);
                    unitofWork.saveChanges();
                    return (HttpStatusCode.OK).ToString();
                }
            }
            catch (Exception)
            {
                return (HttpStatusCode.InternalServerError).ToString();
            }
        }
        public BlockDto GetBlock(int blockID)
        {
            try
            {
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    block item = new block();
                    item = unitofWork.GetRepository<block>().GetById(x => x.BlockID == blockID);
                    BlockDto blockDto = new BlockDto();
                    blockDto.BlockID = (int)item.BlockID;
                    blockDto.BuildID = (int)item.BuildID;
                    blockDto.Name = item.Name;
                    blockDto.Gps = item.Gps;
                    return blockDto;
                }
            }
            catch (Exception ex)
            {
                return new BlockDto();
            }
        }
        public bool isThere(BlockDto blockDto)
        {
            using (UnitOfWork unitofWork = new UnitOfWork())
            {
                var item = unitofWork.GetRepository<block>().GetById(x => x.BuildID == blockDto.BuildID && x.Name ==blockDto.Name);
                if (item != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public List<BlockDto> GetAllBlock()
        {
            try
            {
                List<BlockDto> list = new List<BlockDto>();
                using (UnitOfWork unitofWork = new UnitOfWork())
                {
                    List<block> collection = unitofWork.GetRepository<block>().Select(null, null).ToList();
                    foreach (var item in collection)
                    {
                        list.Add(new BlockDto { BlockID=item.BlockID, BuildID= item.BuildID.Value,Gps=item.Gps,Name=item.Name  });
                    }
                    return list;
                }
            }
            catch (Exception ex)
            {
                return new List<BlockDto>();
            }
        }
    }
}