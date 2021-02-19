﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ventus.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class QueryTemplates {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal QueryTemplates() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Ventus.Properties.QueryTemplates", typeof(QueryTemplates).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE PROCEDURE {T}Count
        ///    @total int OUTPUT
        ///AS
        ///    SET NOCOUNT ON
        ///
        ///    SELECT @total = COUNT(*)
        ///      FROM Orden
        ///     WHERE Activo = 1.
        /// </summary>
        internal static string Count {
            get {
                return ResourceManager.GetString("Count", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE PROCEDURE {T}Delete
        ///	@ID int
        ///AS
        ///	SET NOCOUNT ON
        ///
        ///	UPDATE {T}
        ///	   SET Activo = 0
        ///	 WHERE ID = @ID.
        /// </summary>
        internal static string Delete {
            get {
                return ResourceManager.GetString("Delete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE PROCEDURE {T}Get
        ///    @ID int
        ///AS
        ///	SET NOCOUNT ON
        ///
        ///    SELECT {C}
        ///      FROM {T}
        ///     WHERE ID = @ID.
        /// </summary>
        internal static string Get {
            get {
                return ResourceManager.GetString("Get", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE PROCEDURE {T}Insert
        ///    @ID                 int OUTPUT,
        ///    {D}
        ///AS
        ///    SET NOCOUNT ON
        ///
        ///    INSERT INTO {T} ({C})
        ///    VALUES ({P})
        ///
        ///    SET @ID = SCOPE_IDENTITY().
        /// </summary>
        internal static string Insert {
            get {
                return ResourceManager.GetString("Insert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE PROCEDURE {T}List
        ///AS
        ///    SET NOCOUNT ON
        ///
        ///    SELECT {C}
        ///      FROM {T}.
        /// </summary>
        internal static string List {
            get {
                return ResourceManager.GetString("List", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE PROCEDURE {T}List
        ///    @start  int,
        ///    @limit  int
        ///AS
        ///	SET NOCOUNT ON
        ///
        ///	DECLARE @t TABLE (Id int, RowNum int)
        ///	INSERT INTO @t (Id, RowNum)
        ///    SELECT ID,
        ///        ROW_NUMBER() OVER(ORDER BY ID) as RowNum
        ///      FROM {T}
        ///     WHERE Activo = 1
        ///
        ///    SELECT ID
        ///      FROM @t
        ///     WHERE (RowNum BETWEEN @start + 1 AND @start + @limit)
        ///     ORDER BY ID.
        /// </summary>
        internal static string ListP {
            get {
                return ResourceManager.GetString("ListP", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE PROCEDURE {T}Save
        ///    @ID                 int OUTPUT,
        ///    {D}
        ///AS
        ///    SET NOCOUNT ON
        ///
        ///IF EXISTS (SELECT * FROM {T} WHERE ID = @ID)
        ///    UPDATE {T}
        ///       SET  {S}
        ///     WHERE ID = @ID
        ///ELSE
        ///    BEGIN
        ///        INSERT INTO {T} ({C})
        ///        VALUES ({P})
        ///
        ///        SET @ID = SCOPE_IDENTITY()
        ///    END.
        /// </summary>
        internal static string Save {
            get {
                return ResourceManager.GetString("Save", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE PROCEDURE {T}Update
        ///    @ID int,
        ///    {D}
        ///AS
        ///    SET NOCOUNT ON
        ///
        ///    UPDATE {T}
        ///       SET {S}
        ///     WHERE ID = @ID.
        /// </summary>
        internal static string Update {
            get {
                return ResourceManager.GetString("Update", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CREATE PROCEDURE {T}Update{F}
        ///    @ID int,
        ///    {DF}
        ///AS
        ///    SET NOCOUNT ON
        ///
        ///    UPDATE {T}
        ///       SET {SF}
        ///     WHERE ID = @ID.
        /// </summary>
        internal static string UpdateF {
            get {
                return ResourceManager.GetString("UpdateF", resourceCulture);
            }
        }
    }
}