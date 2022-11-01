﻿using sakilaAppMySQL.Dtos.ActorsDto;
using Swashbuckle.AspNetCore.Filters;

namespace sakilaAppMySQL.Swagger.Actor
{
  public class ActorExample : IMultipleExamplesProvider<ActorDto>
  {
    public IEnumerable<SwaggerExample<ActorDto>> GetExamples()
    {
      yield return SwaggerExample.Create(
        "Example",
        new ActorDto()
        {
          ActorId = 1,
          FirstName = "PENELOPE",
          LastName = "GUINESS",
          LastUpdate = DateTime.Now
        }
      );
    }
  }
}
