package crc64f43b2c7734b50d7f;


public class EmpleadoListAdapterViewHolder
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("DemoListView.EmpleadoListAdapterViewHolder, DemoListView", EmpleadoListAdapterViewHolder.class, __md_methods);
	}


	public EmpleadoListAdapterViewHolder ()
	{
		super ();
		if (getClass () == EmpleadoListAdapterViewHolder.class)
			mono.android.TypeManager.Activate ("DemoListView.EmpleadoListAdapterViewHolder, DemoListView", "", this, new java.lang.Object[] {  });
	}

	private java.util.ArrayList refList;
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
