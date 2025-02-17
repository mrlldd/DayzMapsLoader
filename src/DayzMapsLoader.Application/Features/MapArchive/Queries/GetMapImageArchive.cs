﻿using DayzMapsLoader.Application.Abstractions.Services;
using MediatR;

namespace DayzMapsLoader.Application.Features.MapArchive.Queries;

public record GetMapImageArchiveQuery(int ProviderId, int MapID, int TypeId, int Zoom) : IRequest<(byte[] data, string name)>;

internal class GetMapImageArchiveHandler : IRequestHandler<GetMapImageArchiveQuery, (byte[] data, string name)>
{
    private readonly IMapDownloadArchiveService _mapDownloader;

    public GetMapImageArchiveHandler(IMapDownloadArchiveService mapDownloader)
    {
        _mapDownloader = mapDownloader;
    }

    public async Task<(byte[] data, string name)> Handle(GetMapImageArchiveQuery request, CancellationToken cancellationToken)
    {
        return await _mapDownloader.DownloadMapImageArchiveAsync(request.ProviderId, request.MapID, request.TypeId, request.Zoom)
            .ConfigureAwait(false);
    }
}