﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_LightProbeProxyVolume_ProbePositionMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.LightProbeProxyVolume.ProbePositionMode");
		addMember(l,0,"CellCorner");
		addMember(l,1,"CellCenter");
		LuaDLL.lua_pop(l, 1);
	}
}
