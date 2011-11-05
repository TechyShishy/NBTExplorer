﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Substrate.Entities
{
    using Substrate.Nbt;

    public class EntityMooshroom : EntityCow
    {
        public static readonly SchemaNodeCompound MooshroomSchema = CowSchema.MergeInto(new SchemaNodeCompound("")
        {
            new SchemaNodeString("id", "MushroomCow"),
        });

        public EntityMooshroom ()
            : base("MushroomCow")
        {
        }

        protected EntityMooshroom (string id)
            : base(id)
        {
        }

        public EntityMooshroom (TypedEntity e)
            : base(e)
        {
        }


        #region INBTObject<Entity> Members

        public override bool ValidateTree (TagNode tree)
        {
            return new NbtVerifier(tree, MooshroomSchema).Verify();
        }

        #endregion


        #region ICopyable<Entity> Members

        public override TypedEntity Copy ()
        {
            return new EntityMooshroom(this);
        }

        #endregion
    }
}
