﻿using Assets.Engine.Scripts.Core.Chunks;

namespace Assets.Engine.Scripts.Common.Extensions
{
    public static class ChunkStateExtension
    {
        public static ChunkState Set(this ChunkState state, ChunkState flag)
        {
            return state|flag;
        }

        public static ChunkState Reset(this ChunkState state, ChunkState flag)
        {
            return state&(~flag);
        }

        public static bool Check(this ChunkState state, ChunkState flag)
        {
            return (state & flag) == flag;
        }

        public static bool CheckAny(this ChunkState state, ChunkState flag)
        {
            return (state & flag) != 0;
        }

        public static ChunkState Reset(this ChunkState state)
        {
            return ChunkState.Idle;
        }
    }
}
