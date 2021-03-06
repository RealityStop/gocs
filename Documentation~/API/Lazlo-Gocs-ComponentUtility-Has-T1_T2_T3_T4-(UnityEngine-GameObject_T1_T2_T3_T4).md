#### [GoCS](./index.md 'index')
### [Lazlo.Gocs](./Lazlo-Gocs.md 'Lazlo.Gocs').[ComponentUtility](./Lazlo-Gocs-ComponentUtility.md 'Lazlo.Gocs.ComponentUtility')
## ComponentUtility.Has&lt;T1,T2,T3,T4&gt;(UnityEngine.GameObject, T1, T2, T3, T4) Method
Checks the game object for the specified components.  
```C#
public static bool Has<T1,T2,T3,T4>(this UnityEngine.GameObject go, out T1 component1, out T2 component2, out T3 component3, out T4 component4);
```
#### Type parameters
<a name='Lazlo-Gocs-ComponentUtility-Has-T1_T2_T3_T4-(UnityEngine-GameObject_T1_T2_T3_T4)-T1'></a>
`T1`  
The type of the first component.  
  
<a name='Lazlo-Gocs-ComponentUtility-Has-T1_T2_T3_T4-(UnityEngine-GameObject_T1_T2_T3_T4)-T2'></a>
`T2`  
The type of the second component.  
  
<a name='Lazlo-Gocs-ComponentUtility-Has-T1_T2_T3_T4-(UnityEngine-GameObject_T1_T2_T3_T4)-T3'></a>
`T3`  
The type of the third component.  
  
<a name='Lazlo-Gocs-ComponentUtility-Has-T1_T2_T3_T4-(UnityEngine-GameObject_T1_T2_T3_T4)-T4'></a>
`T4`  
The type of the fourth component.  
  
#### Parameters
<a name='Lazlo-Gocs-ComponentUtility-Has-T1_T2_T3_T4-(UnityEngine-GameObject_T1_T2_T3_T4)-go'></a>
`go` [UnityEngine.GameObject](https://docs.microsoft.com/en-us/dotnet/api/UnityEngine.GameObject 'UnityEngine.GameObject')  
The game object.  
  
<a name='Lazlo-Gocs-ComponentUtility-Has-T1_T2_T3_T4-(UnityEngine-GameObject_T1_T2_T3_T4)-component1'></a>
`component1` [T1](#Lazlo-Gocs-ComponentUtility-Has-T1_T2_T3_T4-(UnityEngine-GameObject_T1_T2_T3_T4)-T1 'Lazlo.Gocs.ComponentUtility.Has&lt;T1,T2,T3,T4&gt;(UnityEngine.GameObject, T1, T2, T3, T4).T1')  
The first returned component.  
  
<a name='Lazlo-Gocs-ComponentUtility-Has-T1_T2_T3_T4-(UnityEngine-GameObject_T1_T2_T3_T4)-component2'></a>
`component2` [T2](#Lazlo-Gocs-ComponentUtility-Has-T1_T2_T3_T4-(UnityEngine-GameObject_T1_T2_T3_T4)-T2 'Lazlo.Gocs.ComponentUtility.Has&lt;T1,T2,T3,T4&gt;(UnityEngine.GameObject, T1, T2, T3, T4).T2')  
The second returned component.  
  
<a name='Lazlo-Gocs-ComponentUtility-Has-T1_T2_T3_T4-(UnityEngine-GameObject_T1_T2_T3_T4)-component3'></a>
`component3` [T3](#Lazlo-Gocs-ComponentUtility-Has-T1_T2_T3_T4-(UnityEngine-GameObject_T1_T2_T3_T4)-T3 'Lazlo.Gocs.ComponentUtility.Has&lt;T1,T2,T3,T4&gt;(UnityEngine.GameObject, T1, T2, T3, T4).T3')  
The third returned component.  
  
<a name='Lazlo-Gocs-ComponentUtility-Has-T1_T2_T3_T4-(UnityEngine-GameObject_T1_T2_T3_T4)-component4'></a>
`component4` [T4](#Lazlo-Gocs-ComponentUtility-Has-T1_T2_T3_T4-(UnityEngine-GameObject_T1_T2_T3_T4)-T4 'Lazlo.Gocs.ComponentUtility.Has&lt;T1,T2,T3,T4&gt;(UnityEngine.GameObject, T1, T2, T3, T4).T4')  
The fourth returned component.  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Whether the game object contains all specified component types.  
