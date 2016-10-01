GameObject = UnityEngine.GameObject

function main()

	-- List<>,Dictionay<> not exported
	-- so return as LuaVarObject
	-- varobj access via reflection, try to avoid using non exported class

	local obj = HelloWorld()

	local list = obj:getList()
	print(list.Count) -- call var's property
	
	for i=3,10 do
		list:Add(GameObject(tostring(i)))
	end

	list[5] = GameObject("Replaced 5")

	-- list index based 0 not 1
	for i=0,9 do
		print(i,list[i],list[i].name) -- access item by index
	end



	print("List count",list.Count) -- call var's property



	local dict = obj:foo()

	for i=1,10 do
		dict:Add(tostring(i),GameObject("dict"..i)) -- add k,v to Dictionary<string,GameObject>
	end
	dict["hello"] = GameObject("world")

	print("Dict count",dict.Count)

	for v in Slua.iter(dict) do
		print("for each",v)
	end

	local dict2 = obj:too()
	dict2[list[5]]="xxx"

	print(dict2.Count)

	-- now we simple benchmark varobj
	local t = os.clock()
	for i=1,200000 do
		local a = dict.Count
	end
	print("Var obj prop get 200k, take time:",os.clock()-t)
	-- you see, varobj is slow, use exported class instead

	-- create class used reflection
	local go=Slua.CreateClass("UnityEngine.GameObject,UnityEngine","VarGameObject")
	print(go.name)
	local array=Slua.CreateClass("System.Collections.ArrayList",10)
	print(array.Capacity)
	array:Add("slua")
	array:Add("unity")
	print(array.Count,array[0],array[1])


	local cls=Slua.GetClass("UnityEngine.Vector3,UnityEngine")
	local cc=cls.one
	cc=cls.Normalize(cc)
	print(cc.x,cc.y,cc.z)

	local r=Slua.CreateClass("Ref")
	r.depth=10
	print(r,r.depth)
end


