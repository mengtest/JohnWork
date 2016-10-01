﻿using UnityEngine;
using System;
using LuaInterface;
using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_CanvasRenderer : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer o;
			o=new UnityEngine.CanvasRenderer();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetColor(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			UnityEngine.Color a1;
			checkType(l,2,out a1);
			self.SetColor(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetColor(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			var ret=self.GetColor();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetAlpha(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			var ret=self.GetAlpha();
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetAlpha(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			System.Single a1;
			checkType(l,2,out a1);
			self.SetAlpha(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int EnableRectClipping(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			UnityEngine.Rect a1;
			checkValueType(l,2,out a1);
			self.EnableRectClipping(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int DisableRectClipping(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			self.DisableRectClipping();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetMaterial(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,2,typeof(UnityEngine.Material),typeof(UnityEngine.Texture))){
				UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
				UnityEngine.Material a1;
				checkType(l,2,out a1);
				UnityEngine.Texture a2;
				checkType(l,3,out a2);
				self.SetMaterial(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(matchType(l,argc,2,typeof(UnityEngine.Material),typeof(int))){
				UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
				UnityEngine.Material a1;
				checkType(l,2,out a1);
				System.Int32 a2;
				checkType(l,3,out a2);
				self.SetMaterial(a1,a2);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetMaterial(IntPtr l) {
		try {
			int argc = LuaDLL.lua_gettop(l);
			if(argc==1){
				UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
				var ret=self.GetMaterial();
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(argc==2){
				UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
				System.Int32 a1;
				checkType(l,2,out a1);
				var ret=self.GetMaterial(a1);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function to call");
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetPopMaterial(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			UnityEngine.Material a1;
			checkType(l,2,out a1);
			System.Int32 a2;
			checkType(l,3,out a2);
			self.SetPopMaterial(a1,a2);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int GetPopMaterial(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			System.Int32 a1;
			checkType(l,2,out a1);
			var ret=self.GetPopMaterial(a1);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetTexture(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			UnityEngine.Texture a1;
			checkType(l,2,out a1);
			self.SetTexture(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetAlphaTexture(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			UnityEngine.Texture a1;
			checkType(l,2,out a1);
			self.SetAlphaTexture(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SetMesh(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			UnityEngine.Mesh a1;
			checkType(l,2,out a1);
			self.SetMesh(a1);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int Clear(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			self.Clear();
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int SplitUIVertexStreams_s(IntPtr l) {
		try {
			System.Collections.Generic.List<UnityEngine.UIVertex> a1;
			checkType(l,1,out a1);
			System.Collections.Generic.List<UnityEngine.Vector3> a2;
			checkType(l,2,out a2);
			System.Collections.Generic.List<UnityEngine.Color32> a3;
			checkType(l,3,out a3);
			System.Collections.Generic.List<UnityEngine.Vector2> a4;
			checkType(l,4,out a4);
			System.Collections.Generic.List<UnityEngine.Vector2> a5;
			checkType(l,5,out a5);
			System.Collections.Generic.List<UnityEngine.Vector3> a6;
			checkType(l,6,out a6);
			System.Collections.Generic.List<UnityEngine.Vector4> a7;
			checkType(l,7,out a7);
			System.Collections.Generic.List<System.Int32> a8;
			checkType(l,8,out a8);
			UnityEngine.CanvasRenderer.SplitUIVertexStreams(a1,a2,a3,a4,a5,a6,a7,a8);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int CreateUIVertexStream_s(IntPtr l) {
		try {
			System.Collections.Generic.List<UnityEngine.UIVertex> a1;
			checkType(l,1,out a1);
			System.Collections.Generic.List<UnityEngine.Vector3> a2;
			checkType(l,2,out a2);
			System.Collections.Generic.List<UnityEngine.Color32> a3;
			checkType(l,3,out a3);
			System.Collections.Generic.List<UnityEngine.Vector2> a4;
			checkType(l,4,out a4);
			System.Collections.Generic.List<UnityEngine.Vector2> a5;
			checkType(l,5,out a5);
			System.Collections.Generic.List<UnityEngine.Vector3> a6;
			checkType(l,6,out a6);
			System.Collections.Generic.List<UnityEngine.Vector4> a7;
			checkType(l,7,out a7);
			System.Collections.Generic.List<System.Int32> a8;
			checkType(l,8,out a8);
			UnityEngine.CanvasRenderer.CreateUIVertexStream(a1,a2,a3,a4,a5,a6,a7,a8);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int AddUIVertexStream_s(IntPtr l) {
		try {
			System.Collections.Generic.List<UnityEngine.UIVertex> a1;
			checkType(l,1,out a1);
			System.Collections.Generic.List<UnityEngine.Vector3> a2;
			checkType(l,2,out a2);
			System.Collections.Generic.List<UnityEngine.Color32> a3;
			checkType(l,3,out a3);
			System.Collections.Generic.List<UnityEngine.Vector2> a4;
			checkType(l,4,out a4);
			System.Collections.Generic.List<UnityEngine.Vector2> a5;
			checkType(l,5,out a5);
			System.Collections.Generic.List<UnityEngine.Vector3> a6;
			checkType(l,6,out a6);
			System.Collections.Generic.List<UnityEngine.Vector4> a7;
			checkType(l,7,out a7);
			UnityEngine.CanvasRenderer.AddUIVertexStream(a1,a2,a3,a4,a5,a6,a7);
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasRectClipping(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.hasRectClipping);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasPopInstruction(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.hasPopInstruction);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_hasPopInstruction(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.hasPopInstruction=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_materialCount(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.materialCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_materialCount(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.materialCount=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_popMaterialCount(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.popMaterialCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_popMaterialCount(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			int v;
			checkType(l,2,out v);
			self.popMaterialCount=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_relativeDepth(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.relativeDepth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_cull(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.cull);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int set_cull(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			bool v;
			checkType(l,2,out v);
			self.cull=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_absoluteDepth(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.absoluteDepth);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_hasMoved(IntPtr l) {
		try {
			UnityEngine.CanvasRenderer self=(UnityEngine.CanvasRenderer)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.hasMoved);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.CanvasRenderer");
		addMember(l,SetColor);
		addMember(l,GetColor);
		addMember(l,GetAlpha);
		addMember(l,SetAlpha);
		addMember(l,EnableRectClipping);
		addMember(l,DisableRectClipping);
		addMember(l,SetMaterial);
		addMember(l,GetMaterial);
		addMember(l,SetPopMaterial);
		addMember(l,GetPopMaterial);
		addMember(l,SetTexture);
		addMember(l,SetAlphaTexture);
		addMember(l,SetMesh);
		addMember(l,Clear);
		addMember(l,SplitUIVertexStreams_s);
		addMember(l,CreateUIVertexStream_s);
		addMember(l,AddUIVertexStream_s);
		addMember(l,"hasRectClipping",get_hasRectClipping,null,true);
		addMember(l,"hasPopInstruction",get_hasPopInstruction,set_hasPopInstruction,true);
		addMember(l,"materialCount",get_materialCount,set_materialCount,true);
		addMember(l,"popMaterialCount",get_popMaterialCount,set_popMaterialCount,true);
		addMember(l,"relativeDepth",get_relativeDepth,null,true);
		addMember(l,"cull",get_cull,set_cull,true);
		addMember(l,"absoluteDepth",get_absoluteDepth,null,true);
		addMember(l,"hasMoved",get_hasMoved,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.CanvasRenderer),typeof(UnityEngine.Component));
	}
}
