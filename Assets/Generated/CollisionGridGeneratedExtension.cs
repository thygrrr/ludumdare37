//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {

    public partial class Entity {

        public CollisionGrid collisionGrid { get { return (CollisionGrid)GetComponent(ComponentIds.CollisionGrid); } }
        public bool hasCollisionGrid { get { return HasComponent(ComponentIds.CollisionGrid); } }

        public Entity AddCollisionGrid(bool[,] newPassible) {
            var component = CreateComponent<CollisionGrid>(ComponentIds.CollisionGrid);
            component.passible = newPassible;
            return AddComponent(ComponentIds.CollisionGrid, component);
        }

        public Entity ReplaceCollisionGrid(bool[,] newPassible) {
            var component = CreateComponent<CollisionGrid>(ComponentIds.CollisionGrid);
            component.passible = newPassible;
            ReplaceComponent(ComponentIds.CollisionGrid, component);
            return this;
        }

        public Entity RemoveCollisionGrid() {
            return RemoveComponent(ComponentIds.CollisionGrid);
        }
    }

    public partial class Pool {

        public Entity collisionGridEntity { get { return GetGroup(Matcher.CollisionGrid).GetSingleEntity(); } }
        public CollisionGrid collisionGrid { get { return collisionGridEntity.collisionGrid; } }
        public bool hasCollisionGrid { get { return collisionGridEntity != null; } }

        public Entity SetCollisionGrid(bool[,] newPassible) {
            if(hasCollisionGrid) {
                throw new EntitasException("Could not set collisionGrid!\n" + this + " already has an entity with CollisionGrid!",
                    "You should check if the pool already has a collisionGridEntity before setting it or use pool.ReplaceCollisionGrid().");
            }
            var entity = CreateEntity();
            entity.AddCollisionGrid(newPassible);
            return entity;
        }

        public Entity ReplaceCollisionGrid(bool[,] newPassible) {
            var entity = collisionGridEntity;
            if(entity == null) {
                entity = SetCollisionGrid(newPassible);
            } else {
                entity.ReplaceCollisionGrid(newPassible);
            }

            return entity;
        }

        public void RemoveCollisionGrid() {
            DestroyEntity(collisionGridEntity);
        }
    }

    public partial class Matcher {

        static IMatcher _matcherCollisionGrid;

        public static IMatcher CollisionGrid {
            get {
                if(_matcherCollisionGrid == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.CollisionGrid);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherCollisionGrid = matcher;
                }

                return _matcherCollisionGrid;
            }
        }
    }
}
