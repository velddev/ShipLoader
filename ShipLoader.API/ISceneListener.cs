﻿namespace ShipLoader.API
{
    public enum SceneUpdateType
    {
        Game_join,
        Game_leave,
        Game_change,
        Menu_change
    }

    public interface ISceneListener
    {

        /// <summary>
        /// Called when a game is active
        /// </summary>
        void UpdateGame(float deltaTime);

        /// <summary>
        /// Called when the menu is active
        /// </summary>
        void UpdateMenu(float deltaTime);

        /// <summary>
        /// Called every update
        /// </summary>
        void Update(float deltaTime);

        /// <summary>
        /// Called when there's a different scene loaded
        /// </summary>
        /// <param name="type">The type of update that occurred</param>
        void OnSceneUpdate(SceneUpdateType type);

        void OnGameJoin();
        void OnGameLeave();
        void OnGameChange();
        void OnMenuChange();

    }
}