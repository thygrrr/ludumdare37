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

        public PooDistance pooDistance { get { return (PooDistance)GetComponent(ComponentIds.PooDistance); } }
        public bool hasPooDistance { get { return HasComponent(ComponentIds.PooDistance); } }

        public Entity AddPooDistance(int newDistance) {
            var component = CreateComponent<PooDistance>(ComponentIds.PooDistance);
            component.distance = newDistance;
            return AddComponent(ComponentIds.PooDistance, component);
        }

        public Entity ReplacePooDistance(int newDistance) {
            var component = CreateComponent<PooDistance>(ComponentIds.PooDistance);
            component.distance = newDistance;
            ReplaceComponent(ComponentIds.PooDistance, component);
            return this;
        }

        public Entity RemovePooDistance() {
            return RemoveComponent(ComponentIds.PooDistance);
        }
    }

    public partial class Matcher {

        static IMatcher _matcherPooDistance;

        public static IMatcher PooDistance {
            get {
                if(_matcherPooDistance == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.PooDistance);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherPooDistance = matcher;
                }

                return _matcherPooDistance;
            }
        }
    }
}