﻿namespace UserManagement.Command.API.ConfigurationModel;

public class RedisConfiguration
{
    public string Host { get; set; }
    public string Port { get; set; }
    public string Password { get; set; }
    public int DatabaseIndex { get; set; }
}