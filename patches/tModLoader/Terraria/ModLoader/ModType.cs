﻿namespace Terraria.ModLoader
{
	/// <summary>
	/// The base type for most modded things.
	/// </summary>
	public abstract class ModType : IModType
	{
		///<summary>
		/// The mod this belongs to.
		/// </summary>
		public Mod Mod { get; internal set; }

		/// <summary>
		/// The internal name of this.
		/// </summary>
		public virtual string Name => GetType().Name;

		void ILoadable.Load(Mod mod) {
			Mod = mod;

			Register();
			Load();
		}

		public virtual void Load() { }

		public virtual void Unload() { }

		protected abstract void Register();
	}
}
