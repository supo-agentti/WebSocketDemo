﻿namespace WebSocketDemo.Domain.Delegates;

/// <summary>
/// Delegate that is invoked when application is stopping.
/// </summary>
/// <returns>Asynchronous operation that is run when application is stopping.</returns>
public delegate Task ApplicationStop(CancellationToken cancellationToken);
