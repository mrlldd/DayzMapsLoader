﻿namespace RequestsHub.Domain.DataTypes
{
    internal class PathsToSave
    {
        private readonly string folderMap;
        private readonly string folderToSave;
        private readonly string folderType;
        private readonly string folderZoom;
        private string folderHorizontal = "Horizontal";
        private string generalFolderToSave;

        public PathsToSave(string FolderToSave, string FolderMap, string FolderType, string FolderZoom)
        {
            folderToSave = FolderToSave;
            folderMap = FolderMap;
            folderType = FolderType;
            folderZoom = FolderZoom;
        }

        public string GeneralFolderToSave
        {
            get
            {
                if (generalFolderToSave == null)
                {
                    generalFolderToSave = $@"{folderToSave}\{folderMap}\{folderType}\{folderZoom}\{folderHorizontal}";
                }
                return generalFolderToSave;
            }
        }
    }
}