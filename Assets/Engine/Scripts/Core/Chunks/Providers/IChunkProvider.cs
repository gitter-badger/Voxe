﻿namespace Assets.Engine.Scripts.Core.Chunks.Providers
{
    /// <summary>
    /// 	Interface for chunk providers
    /// </summary>
    public interface IChunkProvider
    {
        Chunk RequestChunk(ChunkManager map, int cx, int cy, int cz);
        bool ReleaseChunk(Chunk chunk);
        
    }
}