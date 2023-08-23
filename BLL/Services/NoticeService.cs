using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class NoticeService
    {
        public static List<NoticeDTO> Get()
        {
            var data = DataAccess.NoticeData().Get();
            var mapper = MapperService<Notice, NoticeDTO>.GetMapper();
            return mapper.Map<List<NoticeDTO>>(data);
        }
        public static NoticeDTO Get(int id)
        {
            var data = DataAccess.NoticeData().Get(id);
            var mapper = MapperService<Notice, NoticeDTO>.GetMapper();
            return mapper.Map<NoticeDTO>(data);
        }
        public static bool Add(NoticeDTO Notice)
        {
            var mapper = MapperService<NoticeDTO, Notice>.GetMapper();
            var mapped = mapper.Map<Notice>(Notice);
            return DataAccess.NoticeData().Add(mapped);

        }
        public static bool Update(NoticeDTO Notice)
        {
            var mapper = MapperService<NoticeDTO, Notice>.GetMapper();
            var mapped = mapper.Map<Notice>(Notice);
            return DataAccess.NoticeData().Update(mapped);

        }
        public static bool Delete(int id)
        {

            return DataAccess.NoticeData().Delete(id);

        }

    }
}
