using System;
using System.Diagnostics.CodeAnalysis;
using FluentMigrator;

namespace CmdLine.DataAccess.Migrations
{
    public abstract class UpOnlyMigration : Migration
    {
        /// <summary>
        /// Do not override/implement this method. [Manfred]
        /// </summary>
        /// <remarks>We never go back, so no need to implement this method. [Manfred]</remarks>
        /// <exception cref="NotImplementedException">Thrown at all times.</exception>
        [SuppressMessage("General", "RCS1079:Throwing of new NotImplementedException.", Justification = "Method not needed.")]
        public sealed override void Down()
        {
            throw new NotImplementedException();
        }

        public abstract override void Up();
    }
}
