﻿using AgentRest.Dto;
using AgentRest.Models;

namespace AgentRest.Service
{
    public interface ITargetService
    {
        Task<IdDto> CreateTargetAsync(TargetDto targetDto);
        Task<List<TargetModel>> GetAvailableTargestAsync(AgentModel agent);
        Task<List<TargetModel>> GetAllTargetsAsync();
        Task<TargetModel?> GetTargetByIdAsync(long id);
        Task<TargetModel> UpdateTargetAsync(long targetId, TargetModel targetModel);
        Task<TargetModel> MoveTargetAsync(long targetId, DirectionDto directionDto);
        Task DeleteTargetAsync(long targetId);
        Task<TargetModel> PinTargetAsync(long targetId, LocationDto locationDto);
    }
}
