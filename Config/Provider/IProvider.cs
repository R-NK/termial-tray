﻿namespace WindowsTermialTray.Config.Provider
{
    interface IProvider
    {
        Config Deserialize(string source);
    }
}
