﻿// <copyright file="IGame.cs" company="KnightsOfOrange">
// Copyright © 2020 KnightsOfOrange. All Rights Reserved.
// </copyright>

namespace KnightsOfOrange.Engine.Abstraction
{
    using System;

    public interface IGame : IDisposable
    {
        ISceneManager SceneManager { get; }

        void Init();

        void AddScene(IScene scene);
    }
}
