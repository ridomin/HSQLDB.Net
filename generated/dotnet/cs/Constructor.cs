/*
 * Copyright (c) 1999-2018 by Codemesh, Inc.
 * ALL RIGHTS RESERVED.
 *
 * Original Java Type: java.lang.reflect.Constructor
 * JRE Version       : 1.8.0_74
 * Template Version  : 1.0.42
 * Codegen Version   : 4.7.416
 * Generated at      : Sat Sep 29 22:36:15 EDT 2018
 */


namespace Java.Lang.Reflect
{
    [global::System.Runtime.InteropServices.GuidAttribute("7CBD8055-D854-2795-E274-EEACF589631A")]
    [global::System.Runtime.InteropServices.ClassInterfaceAttribute(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDual)]
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="java.lang.reflect.Constructor")]
    public sealed class Constructor :
        global::Java.Lang.Reflect.GenericDeclarationImpl
    { 
    
        private static readonly global::Codemesh.JuggerNET.JavaClass    _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun0;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun1;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun2;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun3;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun4;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun5;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun6;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun7;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun8;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun9;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun10;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun11;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun12;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun13;
        private static readonly global::Codemesh.JuggerNET.JavaMethod   _cmj_fun14;
    
        static Constructor()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.lang.reflect.Constructor", typeof(global::Java.Lang.Reflect.Constructor));
            _cmj_fun0 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Reflect.AnnotatedType), "getAnnotatedReceiverType", "()Ljava/lang/reflect/AnnotatedType;", false, false, false );
            _cmj_fun1 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Reflect.AnnotatedType), "getAnnotatedReturnType", "()Ljava/lang/reflect/AnnotatedType;", false, false, false );
            _cmj_fun2 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Class), "getDeclaringClass", "()Ljava/lang/Class;", false, false, false );
            _cmj_fun3 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.ClassArray), "getExceptionTypes", "()[Ljava/lang/Class;", false, false, false );
            _cmj_fun4 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Reflect.TypeArray), "getGenericExceptionTypes", "()[Ljava/lang/reflect/Type;", false, false, false );
            _cmj_fun5 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Reflect.TypeArray), "getGenericParameterTypes", "()[Ljava/lang/reflect/Type;", false, false, false );
            _cmj_fun6 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getModifiers", "()I", false, false, false );
            _cmj_fun7 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "getName", "()Ljava/lang/String;", false, false, false );
            _cmj_fun8 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Annotation.AnnotationArrayArray), "getParameterAnnotations", "()[[Ljava/lang/annotation/Annotation;", false, false, false );
            _cmj_fun9 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(int), "getParameterCount", "()I", false, false, false );
            _cmj_fun10 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.ClassArray), "getParameterTypes", "()[Ljava/lang/Class;", false, false, false );
            _cmj_fun11 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isSynthetic", "()Z", false, false, false );
            _cmj_fun12 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(bool), "isVarArgs", "()Z", false, false, false );
            _cmj_fun13 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(object), "newInstance", "([Ljava/lang/Object;)Ljava/lang/Object;", false, false, false );
            _cmj_fun14 = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(string), "toGenericString", "()Ljava/lang/String;", false, false, false );
        }
    
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle.
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobj"> The JNI object handle.</param>
        public Constructor( global::Codemesh.JuggerNET.JNIHandle jobj ) : base( jobj ) {	}
    
    
        /// <summary>Returns an instance of type Constructor if the given proxy instance
        /// represents a Java object that is type-compatible with java.lang.reflect.Constructor</summary>
        /// This function returns <c>null</c> if the passed object is not a type-compatible
        /// proxy object.
        /// <param name="proxy">A proxy object of any type.</param>
        public static new global::Java.Lang.Reflect.Constructor From( object proxy )
        {
            global::Codemesh.JuggerNET.JavaProxy   jp = proxy as global::Codemesh.JuggerNET.JavaProxy;
            if (jp != null && _cmj_theClass.IsTypeOf(jp))
                return new global::Java.Lang.Reflect.Constructor(new global::Codemesh.JuggerNET.JNIHandle(jp.JObjectDuplicate));
            else
                return null;
        }
        public global::Java.Lang.Reflect.AnnotatedType GetAnnotatedReceiverType()
        {
            if(_cmj_fun0.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun0.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Reflect.AnnotatedTypeImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.Reflect.AnnotatedType)_cmj_fun0.CallObject( this, typeof(global::Java.Lang.Reflect.AnnotatedType), false );
        
        }    
    
        public global::Java.Lang.Reflect.AnnotatedType GetAnnotatedReturnType()
        {
            if(_cmj_fun1.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun1.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Reflect.AnnotatedTypeImpl( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.Reflect.AnnotatedType)_cmj_fun1.CallObject( this, typeof(global::Java.Lang.Reflect.AnnotatedType), false );
        
        }    
    
        public global::Java.Lang.Class GetDeclaringClass()
        {
            long    jnet_ref = (long)_cmj_fun2.CallObject( this );
            return  jnet_ref == 0 ? null : new global::Java.Lang.Class( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
        }    
    
        public global::Java.Lang.ClassArray GetExceptionTypes()
        {
            if(_cmj_fun3.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun3.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.ClassArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.ClassArray)_cmj_fun3.CallObject( this, typeof(global::Java.Lang.ClassArray), false );
        
        }    
    
        public global::Java.Lang.Reflect.TypeArray GetGenericExceptionTypes()
        {
            if(_cmj_fun4.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun4.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Reflect.TypeArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.Reflect.TypeArray)_cmj_fun4.CallObject( this, typeof(global::Java.Lang.Reflect.TypeArray), false );
        
        }    
    
        public global::Java.Lang.Reflect.TypeArray GetGenericParameterTypes()
        {
            if(_cmj_fun5.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun5.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Reflect.TypeArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.Reflect.TypeArray)_cmj_fun5.CallObject( this, typeof(global::Java.Lang.Reflect.TypeArray), false );
        
        }    
    
        public int GetModifiers()
        {
            return _cmj_fun6.CallInt( this );
        }    
    
        public string GetName()
        {
            return _cmj_fun7.CallString( this );
        }    
    
        public global::Java.Lang.Annotation.AnnotationArrayArray GetParameterAnnotations()
        {
            if(_cmj_fun8.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun8.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.Annotation.AnnotationArrayArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.Annotation.AnnotationArrayArray)_cmj_fun8.CallObject( this, typeof(global::Java.Lang.Annotation.AnnotationArrayArray), false );
        
        }    
    
        public int GetParameterCount()
        {
            return _cmj_fun9.CallInt( this );
        }    
    
        public global::Java.Lang.ClassArray GetParameterTypes()
        {
            if(_cmj_fun10.IsLeafType)
            {
                long    jnet_ref = (long)_cmj_fun10.CallObject( this );
                return  jnet_ref == 0 ? null : new global::Java.Lang.ClassArray( new global::Codemesh.JuggerNET.JNIHandle(jnet_ref) );
            }
            else
                return (global::Java.Lang.ClassArray)_cmj_fun10.CallObject( this, typeof(global::Java.Lang.ClassArray), false );
        
        }    
    
        public bool IsSynthetic()
        {
            return _cmj_fun11.CallBool( this );
        }    
    
        public bool IsVarArgs()
        {
            return _cmj_fun12.CallBool( this );
        }    
    
        public object NewInstance(global::Java.Lang.ObjectArray initargs)
        {
            global::Codemesh.JuggerNET.jvalue[]   cmj_jargs = new global::Codemesh.JuggerNET.jvalue[ 1 ];
            using( global::Codemesh.JuggerNET.JavaMethodArguments cmj_jmargs = new global::Codemesh.JuggerNET.JavaMethodArguments( cmj_jargs ).Add(initargs) )
            {
                return _cmj_fun13.CallObject( this, typeof(object), false, cmj_jmargs );
            }
        }    
    
        public string ToGenericString()
        {
            return _cmj_fun14.CallString( this );
        }    
    
    
    }
    
    [global::Codemesh.JuggerNET.JuggerNETProxyType(IsLeafType=true, CodegenVersion="4.7.416", JavaName="[Ljava/lang/reflect/Constructor;")]
    public sealed class ConstructorArray :
        global::Codemesh.JuggerNET.JuggerNETProxyArray,
        global::Java.Lang.Cloneable,
        global::Java.Io.Serializable
    {
        private static readonly global::Codemesh.JuggerNET.JavaClass   _cmj_theClass;
        private static readonly global::Codemesh.JuggerNET.JavaClass   _cmj_theElementClass;
        private static readonly global::Codemesh.JuggerNET.JavaMethod  _cmj_theCtor;
    
        static ConstructorArray()
        {
            _cmj_theClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("[Ljava/lang/reflect/Constructor;", typeof(global::Java.Lang.Reflect.ConstructorArray));
            _cmj_theCtor = new global::Codemesh.JuggerNET.JavaMethod( _cmj_theClass, typeof(global::Java.Lang.Reflect.ConstructorArray), "<arrinit>", "L", false );
            _cmj_theElementClass = global::Codemesh.JuggerNET.JavaClass.RegisterClass("java.lang.reflect.Constructor", typeof(global::Java.Lang.Reflect.Constructor));
        }
    
        ///<summary>The constructor taking a dimension as an argument.</summary>
        ///<remarks>Use this constructor where you would normally declare a native array.
        ///instance using rectangular brackets (i.e. ClassArray[ 25 ];).
        /// This constructor will create an empty (null-initialized) array with space for
        /// the given number of elements.</remarks>
        /// <param name="size"> the number of elements that can be stored in the array (the dimension)</param>
        public ConstructorArray(int size) : base(_cmj_theCtor, _cmj_theElementClass, size) {}
    
        /// <summary>Creates a .NET proxy instance from an existing JNI object handle
        /// <para>You should never have to use this constructor explicitly. It is a
        /// constructor that is required by the JuggerNET framework.</para></summary>
        /// <param name="jobject"> The JNI object handle.</param>
        public ConstructorArray( global::Codemesh.JuggerNET.JNIHandle jobject) : base(jobject) {}
    
    
        /// <summary>Creates a proxy array from a native array</summary>
        /// <param name="arr">the native array instance.</param>
        public ConstructorArray(global::Java.Lang.Reflect.Constructor[] arr) : base(_cmj_theCtor, _cmj_theElementClass, arr.Length)
        {
            int iMax = arr.Length;
            for (int i = 0; i < iMax; i++)
                SetElement(i, (Constructor)arr[i]);
        }
    
    
        /// <summary>Conversion operator from native .NET arrays of the element type.</summary>
        /// <remarks>This operator allows you to use native .NET arrays in places where the
        /// compiler expects proxy array instances. You're better off using proxy arrays if you
        /// are going to use the same native array with Java APIs more than once because the entire.
        /// .NET array has to be converted to a proxy array each time you convert it.
        /// </remarks>
        public static implicit operator ConstructorArray(global::Java.Lang.Reflect.Constructor[] arr)
        {
            int iMax = arr.Length;
            ConstructorArray a = new ConstructorArray(iMax);
            for (int i = 0; i < iMax; i++)
                a.SetElement(i, (Constructor)arr[i]);
            return a;
        }
    
    
        /// <summary>Conversion operator from proxy arrays to .NET arrays of the element type.</summary>
        /// <remarks>This operator allows you to use proxy arrays in places where the
        /// compiler expects native .NET array instances. We declare this operator explicit to prevent
        /// you from using it unintentionally. The performance penalty of unintentionally creating a
        /// .NET array from a proxy array can be significant if you're not planning to use all elements
        /// anyway. 
        /// </remarks>
        public static explicit operator global::Java.Lang.Reflect.Constructor[](ConstructorArray arr)
        {
            global::Java.Lang.Reflect.Constructor[] a = new global::Java.Lang.Reflect.Constructor[ arr.Length ];
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
        public static ConstructorArray From(global::Codemesh.JuggerNET.JavaProxy proxy)
        {
            if (_cmj_theClass.IsTypeOf(proxy))
                return new ConstructorArray(new global::Codemesh.JuggerNET.JNIHandle(proxy.JObjectDuplicate));
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
            get { return typeof(Constructor); }
        }
    
        ///<summary>The index operator allowing access to the array's elements.</summary>
        public Constructor this[ int index ]
        {
            get
            {
                global::Codemesh.JuggerNET.JNIHandle h = GetElement( index );
                return !h ? null : new Constructor( h );
            }
            set
            {
                SetElement( index, value ); global::System.GC.KeepAlive( this ); global::System.GC.KeepAlive( value );
            }
        }
    }
    
    
    

}
