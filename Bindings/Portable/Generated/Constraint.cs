// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// Constraint.cs
// 
// Copyright 2015 Xamarin Inc. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Urho.Urho2D;
using Urho.Gui;
using Urho.Resources;
using Urho.IO;
using Urho.Navigation;
using Urho.Network;

namespace Urho.Physics
{
	/// <summary>
	/// Physics constraint component. Connects two rigid bodies together, or one rigid body to a static point.
	/// </summary>
	public unsafe partial class Constraint : Component
	{
		public Constraint (IntPtr handle) : base (handle)
		{
		}

		protected Constraint (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Constraint_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (Constraint_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Constraint_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (Constraint_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Constraint_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(Constraint));
			return new StringHash (Constraint_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Constraint_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(Constraint));
			return Marshal.PtrToStringAnsi (Constraint_GetTypeNameStatic ());
		}

		public Constraint () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Constraint_Constraint (IntPtr context);

		public Constraint (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(Constraint));
			handle = Constraint_Constraint ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Constraint_RegisterObject (IntPtr context);

		/// <summary>
		/// Register object factory.
		/// </summary>
		public new static void RegisterObject (Context context)
		{
			Runtime.Validate (typeof(Constraint));
			Constraint_RegisterObject ((object)context == null ? IntPtr.Zero : context.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Constraint_ApplyAttributes (IntPtr handle);

		/// <summary>
		/// Apply attribute changes that can not be applied immediately. Called after scene load or a network update.
		/// </summary>
		public override void ApplyAttributes ()
		{
			Runtime.ValidateRefCounted (this);
			Constraint_ApplyAttributes (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Constraint_OnSetEnabled (IntPtr handle);

		/// <summary>
		/// Handle enabled/disabled state change.
		/// </summary>
		public override void OnSetEnabled ()
		{
			Runtime.ValidateRefCounted (this);
			Constraint_OnSetEnabled (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Constraint_DrawDebugGeometry (IntPtr handle, IntPtr debug, bool depthTest);

		/// <summary>
		/// Visualize the component as debug geometry.
		/// </summary>
		public override void DrawDebugGeometry (DebugRenderer debug, bool depthTest)
		{
			Runtime.ValidateRefCounted (this);
			Constraint_DrawDebugGeometry (handle, (object)debug == null ? IntPtr.Zero : debug.Handle, depthTest);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Constraint_SetConstraintType (IntPtr handle, ConstraintType type);

		/// <summary>
		/// Set constraint type and recreate the constraint.
		/// </summary>
		private void SetConstraintType (ConstraintType type)
		{
			Runtime.ValidateRefCounted (this);
			Constraint_SetConstraintType (handle, type);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Constraint_SetOtherBody (IntPtr handle, IntPtr body);

		/// <summary>
		/// Set other body to connect to. Set to null to connect to the static world.
		/// </summary>
		private void SetOtherBody (RigidBody body)
		{
			Runtime.ValidateRefCounted (this);
			Constraint_SetOtherBody (handle, (object)body == null ? IntPtr.Zero : body.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Constraint_SetPosition (IntPtr handle, ref Urho.Vector3 position);

		/// <summary>
		/// Set constraint position relative to own body.
		/// </summary>
		private void SetPosition (Urho.Vector3 position)
		{
			Runtime.ValidateRefCounted (this);
			Constraint_SetPosition (handle, ref position);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Constraint_SetRotation (IntPtr handle, ref Urho.Quaternion rotation);

		/// <summary>
		/// Set constraint rotation relative to own body.
		/// </summary>
		private void SetRotation (Urho.Quaternion rotation)
		{
			Runtime.ValidateRefCounted (this);
			Constraint_SetRotation (handle, ref rotation);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Constraint_SetAxis (IntPtr handle, ref Urho.Vector3 axis);

		/// <summary>
		/// Set constraint rotation relative to own body by specifying the axis.
		/// </summary>
		public void SetAxis (Urho.Vector3 axis)
		{
			Runtime.ValidateRefCounted (this);
			Constraint_SetAxis (handle, ref axis);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Constraint_SetOtherPosition (IntPtr handle, ref Urho.Vector3 position);

		/// <summary>
		/// Set constraint position relative to the other body. If connected to the static world, is a world space position.
		/// </summary>
		private void SetOtherPosition (Urho.Vector3 position)
		{
			Runtime.ValidateRefCounted (this);
			Constraint_SetOtherPosition (handle, ref position);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Constraint_SetOtherRotation (IntPtr handle, ref Urho.Quaternion rotation);

		/// <summary>
		/// Set constraint rotation relative to the other body. If connected to the static world, is a world space rotation.
		/// </summary>
		private void SetOtherRotation (Urho.Quaternion rotation)
		{
			Runtime.ValidateRefCounted (this);
			Constraint_SetOtherRotation (handle, ref rotation);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Constraint_SetOtherAxis (IntPtr handle, ref Urho.Vector3 axis);

		/// <summary>
		/// Set constraint rotation relative to the other body by specifying the axis.
		/// </summary>
		public void SetOtherAxis (Urho.Vector3 axis)
		{
			Runtime.ValidateRefCounted (this);
			Constraint_SetOtherAxis (handle, ref axis);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Constraint_SetWorldPosition (IntPtr handle, ref Urho.Vector3 position);

		/// <summary>
		/// Set constraint world space position. Resets both own and other body relative position, ie. zeroes the constraint error.
		/// </summary>
		public void SetWorldPosition (Urho.Vector3 position)
		{
			Runtime.ValidateRefCounted (this);
			Constraint_SetWorldPosition (handle, ref position);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Constraint_SetHighLimit (IntPtr handle, ref Urho.Vector2 limit);

		/// <summary>
		/// Set high limit. Interpretation is constraint type specific.
		/// </summary>
		private void SetHighLimit (Urho.Vector2 limit)
		{
			Runtime.ValidateRefCounted (this);
			Constraint_SetHighLimit (handle, ref limit);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Constraint_SetLowLimit (IntPtr handle, ref Urho.Vector2 limit);

		/// <summary>
		/// Set low limit. Interpretation is constraint type specific.
		/// </summary>
		private void SetLowLimit (Urho.Vector2 limit)
		{
			Runtime.ValidateRefCounted (this);
			Constraint_SetLowLimit (handle, ref limit);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Constraint_SetERP (IntPtr handle, float erp);

		/// <summary>
		/// Set constraint error reduction parameter. Zero = leave to default.
		/// </summary>
		private void SetERP (float erp)
		{
			Runtime.ValidateRefCounted (this);
			Constraint_SetERP (handle, erp);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Constraint_SetCFM (IntPtr handle, float cfm);

		/// <summary>
		/// Set constraint force mixing parameter. Zero = leave to default.
		/// </summary>
		private void SetCFM (float cfm)
		{
			Runtime.ValidateRefCounted (this);
			Constraint_SetCFM (handle, cfm);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Constraint_SetDisableCollision (IntPtr handle, bool disable);

		/// <summary>
		/// Set whether to disable collisions between connected bodies.
		/// </summary>
		private void SetDisableCollision (bool disable)
		{
			Runtime.ValidateRefCounted (this);
			Constraint_SetDisableCollision (handle, disable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Constraint_GetPhysicsWorld (IntPtr handle);

		/// <summary>
		/// Return physics world.
		/// </summary>
		private PhysicsWorld GetPhysicsWorld ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<PhysicsWorld> (Constraint_GetPhysicsWorld (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern ConstraintType Constraint_GetConstraintType (IntPtr handle);

		/// <summary>
		/// Return constraint type.
		/// </summary>
		private ConstraintType GetConstraintType ()
		{
			Runtime.ValidateRefCounted (this);
			return Constraint_GetConstraintType (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Constraint_GetOwnBody (IntPtr handle);

		/// <summary>
		/// Return rigid body in own scene node.
		/// </summary>
		private RigidBody GetOwnBody ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<RigidBody> (Constraint_GetOwnBody (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Constraint_GetOtherBody (IntPtr handle);

		/// <summary>
		/// Return the other rigid body. May be null if connected to the static world.
		/// </summary>
		private RigidBody GetOtherBody ()
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<RigidBody> (Constraint_GetOtherBody (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Vector3 Constraint_GetPosition (IntPtr handle);

		/// <summary>
		/// Return constraint position relative to own body.
		/// </summary>
		private Urho.Vector3 GetPosition ()
		{
			Runtime.ValidateRefCounted (this);
			return Constraint_GetPosition (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Quaternion Constraint_GetRotation (IntPtr handle);

		/// <summary>
		/// Return constraint rotation relative to own body.
		/// </summary>
		private Urho.Quaternion GetRotation ()
		{
			Runtime.ValidateRefCounted (this);
			return Constraint_GetRotation (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Vector3 Constraint_GetOtherPosition (IntPtr handle);

		/// <summary>
		/// Return constraint position relative to other body.
		/// </summary>
		private Urho.Vector3 GetOtherPosition ()
		{
			Runtime.ValidateRefCounted (this);
			return Constraint_GetOtherPosition (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Quaternion Constraint_GetOtherRotation (IntPtr handle);

		/// <summary>
		/// Return constraint rotation relative to other body.
		/// </summary>
		private Urho.Quaternion GetOtherRotation ()
		{
			Runtime.ValidateRefCounted (this);
			return Constraint_GetOtherRotation (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Vector3 Constraint_GetWorldPosition (IntPtr handle);

		/// <summary>
		/// Return constraint world position, calculated from own body.
		/// </summary>
		private Vector3 GetWorldPosition ()
		{
			Runtime.ValidateRefCounted (this);
			return Constraint_GetWorldPosition (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Vector2 Constraint_GetHighLimit (IntPtr handle);

		/// <summary>
		/// Return high limit.
		/// </summary>
		private Urho.Vector2 GetHighLimit ()
		{
			Runtime.ValidateRefCounted (this);
			return Constraint_GetHighLimit (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Vector2 Constraint_GetLowLimit (IntPtr handle);

		/// <summary>
		/// Return low limit.
		/// </summary>
		private Urho.Vector2 GetLowLimit ()
		{
			Runtime.ValidateRefCounted (this);
			return Constraint_GetLowLimit (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float Constraint_GetERP (IntPtr handle);

		/// <summary>
		/// Return constraint error reduction parameter.
		/// </summary>
		private float GetERP ()
		{
			Runtime.ValidateRefCounted (this);
			return Constraint_GetERP (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float Constraint_GetCFM (IntPtr handle);

		/// <summary>
		/// Return constraint force mixing parameter.
		/// </summary>
		private float GetCFM ()
		{
			Runtime.ValidateRefCounted (this);
			return Constraint_GetCFM (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Constraint_GetDisableCollision (IntPtr handle);

		/// <summary>
		/// Return whether collisions between connected bodies are disabled.
		/// </summary>
		private bool GetDisableCollision ()
		{
			Runtime.ValidateRefCounted (this);
			return Constraint_GetDisableCollision (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Constraint_ReleaseConstraint (IntPtr handle);

		/// <summary>
		/// Release the constraint.
		/// </summary>
		public void ReleaseConstraint ()
		{
			Runtime.ValidateRefCounted (this);
			Constraint_ReleaseConstraint (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Constraint_ApplyFrames (IntPtr handle);

		/// <summary>
		/// Apply constraint frames.
		/// </summary>
		public void ApplyFrames ()
		{
			Runtime.ValidateRefCounted (this);
			Constraint_ApplyFrames (handle);
		}

		public override StringHash Type {
			get {
				return UrhoGetType ();
			}
		}

		public override string TypeName {
			get {
				return GetTypeName ();
			}
		}

		public new static StringHash TypeStatic {
			get {
				return GetTypeStatic ();
			}
		}

		public new static string TypeNameStatic {
			get {
				return GetTypeNameStatic ();
			}
		}

		/// <summary>
		/// Return constraint type.
		/// Or
		/// Set constraint type and recreate the constraint.
		/// </summary>
		public ConstraintType ConstraintType {
			get {
				return GetConstraintType ();
			}
			set {
				SetConstraintType (value);
			}
		}

		/// <summary>
		/// Return the other rigid body. May be null if connected to the static world.
		/// Or
		/// Set other body to connect to. Set to null to connect to the static world.
		/// </summary>
		public RigidBody OtherBody {
			get {
				return GetOtherBody ();
			}
			set {
				SetOtherBody (value);
			}
		}

		/// <summary>
		/// Return constraint position relative to own body.
		/// Or
		/// Set constraint position relative to own body.
		/// </summary>
		public Urho.Vector3 Position {
			get {
				return GetPosition ();
			}
			set {
				SetPosition (value);
			}
		}

		/// <summary>
		/// Return constraint rotation relative to own body.
		/// Or
		/// Set constraint rotation relative to own body.
		/// </summary>
		public Urho.Quaternion Rotation {
			get {
				return GetRotation ();
			}
			set {
				SetRotation (value);
			}
		}

		/// <summary>
		/// Return constraint position relative to other body.
		/// Or
		/// Set constraint position relative to the other body. If connected to the static world, is a world space position.
		/// </summary>
		public Urho.Vector3 OtherPosition {
			get {
				return GetOtherPosition ();
			}
			set {
				SetOtherPosition (value);
			}
		}

		/// <summary>
		/// Return constraint rotation relative to other body.
		/// Or
		/// Set constraint rotation relative to the other body. If connected to the static world, is a world space rotation.
		/// </summary>
		public Urho.Quaternion OtherRotation {
			get {
				return GetOtherRotation ();
			}
			set {
				SetOtherRotation (value);
			}
		}

		/// <summary>
		/// Return constraint world position, calculated from own body.
		/// </summary>
		public Vector3 WorldPosition {
			get {
				return GetWorldPosition ();
			}
		}

		/// <summary>
		/// Return high limit.
		/// Or
		/// Set high limit. Interpretation is constraint type specific.
		/// </summary>
		public Urho.Vector2 HighLimit {
			get {
				return GetHighLimit ();
			}
			set {
				SetHighLimit (value);
			}
		}

		/// <summary>
		/// Return low limit.
		/// Or
		/// Set low limit. Interpretation is constraint type specific.
		/// </summary>
		public Urho.Vector2 LowLimit {
			get {
				return GetLowLimit ();
			}
			set {
				SetLowLimit (value);
			}
		}

		/// <summary>
		/// Return constraint error reduction parameter.
		/// Or
		/// Set constraint error reduction parameter. Zero = leave to default.
		/// </summary>
		public float ERP {
			get {
				return GetERP ();
			}
			set {
				SetERP (value);
			}
		}

		/// <summary>
		/// Return constraint force mixing parameter.
		/// Or
		/// Set constraint force mixing parameter. Zero = leave to default.
		/// </summary>
		public float CFM {
			get {
				return GetCFM ();
			}
			set {
				SetCFM (value);
			}
		}

		/// <summary>
		/// Return whether collisions between connected bodies are disabled.
		/// Or
		/// Set whether to disable collisions between connected bodies.
		/// </summary>
		public bool DisableCollision {
			get {
				return GetDisableCollision ();
			}
			set {
				SetDisableCollision (value);
			}
		}

		/// <summary>
		/// Return physics world.
		/// </summary>
		public PhysicsWorld PhysicsWorld {
			get {
				return GetPhysicsWorld ();
			}
		}

		/// <summary>
		/// Return rigid body in own scene node.
		/// </summary>
		public RigidBody OwnBody {
			get {
				return GetOwnBody ();
			}
		}
	}
}