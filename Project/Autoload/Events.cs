using Godot;
using System;

public partial class Events : Node
{
    // Player signals
    [Signal]
    public delegate void DamagedEventHandler(Node target, float amount, Node origin);

    [Signal]
    public delegate void UpgradeChosenEventHandler();

    [Signal]
    public delegate void PlayerSpawnedEventHandler(PlayerShip player);

    /// Enemy signals
    [Signal]
    public delegate void EnemyAdriftEventHandler(PhysicsBody2D body);

    [Signal]
    public delegate void SpaceCrabDiedEventHandler();

    // Game signals
    [Signal]
    public delegate void NodeSpawnedEventHandler();

    [Signal]
    public delegate void GameMinutePassedEventHandler(float totalTimeElapsed);

    [Signal]
    public delegate void GameThirtySecondsPassedEventHandler(float totalTimeElapsed);

    [Signal]
    public delegate void GameTenSecondsPassedEventHandler(float totalTimeElapsed);

    [Signal]
    public delegate void AddPointsEventHandler(Int32 points);
}