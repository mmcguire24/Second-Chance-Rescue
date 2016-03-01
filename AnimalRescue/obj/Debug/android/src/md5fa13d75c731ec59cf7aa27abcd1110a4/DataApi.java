package md5fa13d75c731ec59cf7aa27abcd1110a4;


public class DataApi
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DogData.DataApi, AnimalRescue, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", DataApi.class, __md_methods);
	}


	public DataApi () throws java.lang.Throwable
	{
		super ();
		if (getClass () == DataApi.class)
			mono.android.TypeManager.Activate ("DogData.DataApi, AnimalRescue, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public DataApi (android.app.Activity p0, java.lang.String p1) throws java.lang.Throwable
	{
		super ();
		if (getClass () == DataApi.class)
			mono.android.TypeManager.Activate ("DogData.DataApi, AnimalRescue, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.App.Activity, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.String, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1 });
	}

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
