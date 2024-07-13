﻿namespace MUnique.OpenMU.GameLogic.Views.Duel;

/// <summary>
/// Interface of a view whose implementation informs about a duel finish.
/// </summary>
public interface IDuelFinishedPlugIn : IViewPlugIn
{
    /// <summary>
    /// The duel has been finished.
    /// </summary>
    /// <param name="winner">The winner.</param>
    /// <param name="loser">The loser.</param>
    ValueTask DuelFinishedAsync(Player winner, Player loser);
}