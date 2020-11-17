UI (WebUI {Angular}, iOS {Swift, SwiftUI})
    |
    V
API (...Controllers)
    |
    | Post..., Get..., Put/Patch..., Delete...
    |
    V
Processing (...Processor)
    |
    | Post... => Create..., Get... => Read..., Put.../Patch... => Update..., Delete... => Delete...
    |
    V
Persistence (...Repository)
    |
    | Create..., Read..., Update..., Delete...
    |
    V
DataAccess (<DbEngine>...Accessor)
    |
    | Create... => Add..., Read... => Select..., Update... => Update..., Delete => Remove...
    |
    V
Object Relationship Mapper
    |
    | Add..., Read..., Update..., Remove...
    |
    V
Database Engine

CrossCutting: DataObjects