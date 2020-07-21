using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Application.Common
{
    public interface IStorageService
    {
        String GetFileUrl(String FileName);

        Task SaveFileAsync(Stream mediaBinaryStream, String FileName);

        Task DeleteFileAsync(string FileName);
    }
}
