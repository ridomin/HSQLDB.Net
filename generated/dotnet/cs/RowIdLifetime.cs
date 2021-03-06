/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.sql.RowIdLifetime
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Sql
{
    [global::System.Runtime.InteropServices.GuidAttribute("A6F27272-D854-2795-E274-EEACF589631A")]
    [global::System.Serializable]
    [global::System.Runtime.InteropServices.ClassInterfaceAttribute(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDual)]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.sql.RowIdLifetime")]
    public sealed class RowIdLifetime :
        global::Java.Lang.Enum,
        global::System.Runtime.Serialization.ISerializable
    
    { 
    
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldROWID_UNSUPPORTED;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldROWID_VALID_FOREVER;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldROWID_VALID_OTHER;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldROWID_VALID_SESSION;
        private static readonly global::Codemesh.JuggerNET.JavaField    _cmj_fldROWID_VALID_TRANSACTION;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun1;
    
        static RowIdLifetime()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.sql.RowIdLifetime", typeof(global::Java.Sql.RowIdLifetime));
            _cmj_fldROWID_UNSUPPORTED = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.RowIdLifetime), "ROWID_UNSUPPORTED", "Ljava/sql/RowIdLifetime;", true, true );
            _cmj_fldROWID_VALID_FOREVER = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.RowIdLifetime), "ROWID_VALID_FOREVER", "Ljava/sql/RowIdLifetime;", true, true );
            _cmj_fldROWID_VALID_OTHER = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.RowIdLifetime), "ROWID_VALID_OTHER", "Ljava/sql/RowIdLifetime;", true, true );
            _cmj_fldROWID_VALID_SESSION = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.RowIdLifetime), "ROWID_VALID_SESSION", "Ljava/sql/RowIdLifetime;", true, true );
            _cmj_fldROWID_VALID_TRANSACTION = new global::Codemesh.JuggerNET.JavaField( _cmj_theClass, typeof(global::Java.Sql.RowIdLifetime), "ROWID_VALID_TRANSACTION", "Ljava/sql/RowIdLifetime;", true, true );
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.RowIdLifetime), "valueOf", "(Ljava/lang/String;)Ljava/sql/RowIdLifetime;", true, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.RowIdLifetimeArray), "values", "()[Ljava/sql/RowIdLifetime;", true, false, false );
        }
    
        public static global::Java.Sql.RowIdLifetime ROWID_UNSUPPORTED
        {
            get
            {
                return (global::Java.Sql.RowIdLifetime)_cmj_fldROWID_UNSUPPORTED.Get_object();
            }
        }
        
        public static global::Java.Sql.RowIdLifetime ROWID_VALID_FOREVER
        {
            get
            {
                return (global::Java.Sql.RowIdLifetime)_cmj_fldROWID_VALID_FOREVER.Get_object();
            }
        }
        
        public static global::Java.Sql.RowIdLifetime ROWID_VALID_OTHER
        {
            get
            {
                return (global::Java.Sql.RowIdLifetime)_cmj_fldROWID_VALID_OTHER.Get_object();
            }
        }
        
        public static global::Java.Sql.RowIdLifetime ROWID_VALID_SESSION
        {
            get
            {
                return (global::Java.Sql.RowIdLifetime)_cmj_fldROWID_VALID_SESSION.Get_object();
            }
        }
        
        public static global::Java.Sql.RowIdLifetime ROWID_VALID_TRANSACTION
        {
            get
            {
                return (global::Java.Sql.RowIdLifetime)_cmj_fldROWID_VALID_TRANSACTION.Get_object();
            }
        }
        
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public RowIdLifetime( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
        ///<summary>Reinflate a serialized object.</summary>
        RowIdLifetime( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) :
            base( global::Codemesh.JuggerNET.NativeInterface.Deserialize( info, context ) )
        {
        }
    
        void global::System.Runtime.Serialization.ISerializable.GetObjectData( global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
        {
            global::Codemesh.JuggerNET.NativeInterface.Serialize( this, info, context );
        }
    
    
        /// <summary>Returns an instance of type RowIdLifetime if the given proxy instance
        /// represents a Java object that is type-compatible with java.sql.RowIdLifetime</summary>
        /// This function returns <c>null</c> if the passed object is not a type-compatible
        /// proxy object.
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Sql.RowIdLifetime From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (jp != null && _cmj_theClass.IsTypeOf(jp))
                return new global::Java.Sql.RowIdLifetime(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        public static global::Java.Sql.RowIdLifetime ValueOf(string arg0)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(arg0) )
            {
                long    jnet_ref = (long)_cmj_fun0.CallObject( null, cmj_jmargs );
                return  jnet_ref == 0 ? null : new global::Java.Sql.RowIdLifetime( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
        }    
    
        public static global::Java.Sql.RowIdLifetimeArray Values()
        {
            if(_cmj_fun1.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun1.CallObject( null );
                return  jnet_ref == 0 ? null : new global::Java.Sql.RowIdLifetimeArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Sql.RowIdLifetimeArray)_cmj_fun1.CallObject( null, typeof(global::Java.Sql.RowIdLifetimeArray), false );
        
        }    
    
    
    }
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="[Ljava/sql/RowIdLifetime;")]
    public sealed class RowIdLifetimeArray :
        global::Codemesh.JuggerNET.JuggerNETProxyArray,
        global::Java.Lang.Cloneable,
        global::Java.Io.Serializable
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass   _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaClass   _cmj_theElementClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod  _cmj_theCtor;
    
        static RowIdLifetimeArray()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("[Ljava/sql/RowIdLifetime;", typeof(global::Java.Sql.RowIdLifetimeArray));
            _cmj_theCtor = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Sql.RowIdLifetimeArray), "<arrinit>", "L", false );
            _cmj_theElementClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.sql.RowIdLifetime", typeof(global::Java.Sql.RowIdLifetime));
        }
    
        ///<summary>The constructor taking a dimension as an argument.</summary>
        ///<remarks>Use this constructor where you would normally declare a native array.
        ///instance using rectangular brackets (i.e. ClassArray[ 25 ];).
        /// This constructor will create an empty (null-initialized) array with space for
        /// the given number of elements.</remarks>
        /// <param name="size"> the number of elements that can be stored in the array (the dimension)</param>
        public RowIdLifetimeArray(int size) : base(_cmj_theCtor, _cmj_theElementClass, size) {}
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobject"> The JNI object handle.</param>
        public RowIdLifetimeArray( global::Codemesh.JuggerNET.JNIHandle jobject) : base(jobject) {}
    
    
        /// <summary>Creates a proxy array from a native array</summary>
        /// <param name="arr">the native array instance.</param>
        public RowIdLifetimeArray(global::Java.Sql.RowIdLifetime[] arr) : base(_cmj_theCtor, _cmj_theElementClass, arr.Length)
        {
            int iMax = arr.Length;
            for (int i = 0; i < iMax; i++)
                SetElement(i, (RowIdLifetime)arr[i]);
        }
    
    
        /// <summary>Conversion operator from native .NET arrays of the element type.</summary>
        /// <remarks>This operator allows you to use native .NET arrays in places where the
        /// compiler expects proxy array instances. You're better off using proxy arrays if you
        /// are going to use the same native array with Java APIs more than once because the entire.
        /// .NET array has to be converted to a proxy array each time you convert it.
        /// </remarks>
        public static implicit operator RowIdLifetimeArray(global::Java.Sql.RowIdLifetime[] arr)
        {
            int iMax = arr.Length;
            RowIdLifetimeArray a = new RowIdLifetimeArray(iMax);
            for (int i = 0; i < iMax; i++)
                a.SetElement(i, (RowIdLifetime)arr[i]);
            return a;
        }
    
    
        /// <summary>Conversion operator from proxy arrays to .NET arrays of the element type.</summary>
        /// <remarks>This operator allows you to use proxy arrays in places where the
        /// compiler expects native .NET array instances. We declare this operator explicit to prevent
        /// you from using it unintentionally. The performance penalty of unintentionally creating a
        /// .NET array from a proxy array can be significant if you're not planning to use all elements
        /// anyway. 
        /// </remarks>
        public static explicit operator global::Java.Sql.RowIdLifetime[](RowIdLifetimeArray arr)
        {
            global::Java.Sql.RowIdLifetime[] a = new global::Java.Sql.RowIdLifetime[ arr.Length ];
            int  length = arr.Length;
            for( int i = 0; i < length; i++ )
                a[ i ] = arr[ i ];
            return a;
        }
        
    
        /// <summary>Casts another proxy object to this type if possible.
        /// <para>You rarely need this method. It is only required when you have for example
        /// an array proxy type that is type compatible on the Java side but not on the .NET side.</para>
        /// <para>A good example would be the <c>String[][]</c> and <c>Object[]</c> types in Java.
        /// The two-dimensional String array IS also a one-dimensional Object array in Java, but we cannot
        /// duplicate this behavior through inheritance in .NET.  For that reason, we provide you with this
        /// method, allowing you to take for exmaple a <c>StringArrayArray</c> object and use it to create
        /// an <c>ObjectArray</c> instance when you need to.</para></summary>
        public static RowIdLifetimeArray From(global::Codemesh.JuggerNET.JavaProxy proxy)
        {
            if (_cmj_theClass.IsTypeOf(proxy))
                return new RowIdLifetimeArray(new global::Codemesh.JuggerNET.JNIHandle(proxy.JObjectDuplicate));
            else
                return null;
        }
    
    
        ///<summary>A read-only property for the array's rank (number of dimensions).</summary>
        public override int Rank
        {
            get { return 1; }
        }
    
    
        ///<summary>A read-only property for the array's element type.</summary>
        public override global::System.Type ElementType
        {
            get { return typeof(RowIdLifetime); }
        }
    
        ///<summary>The index operator allowing access to the array's elements.</summary>
        public RowIdLifetime this[ int index ]
        {
            get
            {
                global::Codemesh.JuggerNET.JNIHandle h = GetElement( index );
                return !h ? null : new RowIdLifetime( h );
            }
            set
            {
                SetElement( index, value ); global::System.GC.KeepAlive( this ); global::System.GC.KeepAlive( value );
            }
        }
    }
    
    
    

}
