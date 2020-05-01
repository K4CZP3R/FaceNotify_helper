using FaceNotify_Helper.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaceNotify_Helper.Services
{
    public class IntegrityChecker
    {
        private string[] NeededFiles { get; set; }
        private string[] FilesToUnpack { get; set; }
        private string UnpackTo { get; set; }
        public IntegrityChecker(string[] neededFiles, string[] filesToUnpack, string unpackTo)
        {
            NeededFiles = neededFiles;
            FilesToUnpack = filesToUnpack;
            UnpackTo = unpackTo;
        }



        private LogicReturn CleanUp()
        {
            try
            {
                if(Directory.Exists(UnpackTo)) Directory.Delete(UnpackTo, true); //Remove files unpacked before
            }
            catch (Exception ex)
            {
                return new LogicReturn { Success = false, Data = $"Delete directory '{UnpackTo}' manually" };
            }
            return new LogicReturn { Success = true };
        }
        public LogicReturn IntegrityCheck()
        {

            var cleanUpResp = CleanUp();
            if (!cleanUpResp.Success)
            {
                return cleanUpResp;
            }


            var filesResp = FilesExist();
            if (!filesResp.Success) return filesResp;

            try
            {
                foreach (string zip in FilesToUnpack) UnpackZip(zip);
            }
            catch (Exception e)
            {
                return new LogicReturn { Success = false, Data = e.Message };
            }


            return new LogicReturn { Success = true, Data = "All integrity checks passed!" };

        }
        private LogicReturn FilesExist()
        {

            foreach (string file in NeededFiles)
            {
                if (!File.Exists(file)) return new LogicReturn { Success = false, Data = $"Missing '{file}'" };
            }
            return new LogicReturn { Success = true };
        }

        private void UnpackZip(string zipPath)
        {
            ZipFile.ExtractToDirectory(zipPath, Path.Combine(Directory.GetCurrentDirectory(), UnpackTo));
        }

    }
}
