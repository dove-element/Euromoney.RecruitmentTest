﻿using System.Collections.Generic;

namespace ContentConsole
{
    public interface IBadWordRepository
    {
        IEnumerable<string> GetAll();
    }
}
