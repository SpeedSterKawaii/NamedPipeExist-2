        public bool PipeExist()
        {
            return Directory.GetFiles(@"\\.\pipe\").Contains($@"\\.\pipe\ThisYourpIPENAME");
        }
