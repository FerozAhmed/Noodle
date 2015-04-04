﻿using System;

namespace Noodle.Extensions.Plugins
{
	/// <summary>
	/// Interface denoting plug-in attributes that are displayed throughout 
	/// the editing interface.
	/// </summary>
    public interface IPlugin : IComparable<IPlugin>
    {
        string Name { get; set; }
        Type Decorates { get; set; }
        int SortOrder { get; }
    }
}
