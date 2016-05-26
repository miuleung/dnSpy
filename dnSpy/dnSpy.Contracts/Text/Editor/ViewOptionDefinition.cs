﻿/*
    Copyright (C) 2014-2016 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

namespace dnSpy.Contracts.Text.Editor {
	/// <summary>
	/// <see cref="ITextView"/> option definition
	/// </summary>
	/// <typeparam name="T">Value type</typeparam>
	public abstract class ViewOptionDefinition<T> : EditorOptionDefinition<T> {
		/// <summary>
		/// Returns true if <paramref name="scope"/> is a <see cref="ITextView"/>
		/// </summary>
		/// <param name="scope">Scope</param>
		/// <returns></returns>
		public override bool IsApplicableToScope(IPropertyOwner scope) => scope is ITextView;
	}
}
