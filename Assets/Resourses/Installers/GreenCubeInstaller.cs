using UnityEngine;
using Zenject;

public class GreenCubeInstaller : MonoInstaller
{
    [SerializeField] private CubeView _greenCubeViewTemplate;

    [SerializeField] private Transform _spawnPoint;
    [SerializeField] [Range(0, 15)] private float _cubeSpeed;

    [Inject] private PlayerInput _input;

    private CubeView _greenCubeView;
    private CubePresenter _greenCubePresenter;

    private MovementBroadcaster _greenCubeMovementBroadcaster;

    public override void InstallBindings()
    {
        var position = _spawnPoint.position;

        _greenCubeView = Container.InstantiatePrefabForComponent<CubeView>(_greenCubeViewTemplate, position,
            Quaternion.identity,
            null);

        var spawnContext = new CubeSpawnContext(position, _cubeSpeed);

        var model = new GreenCube(spawnContext);

        Container.BindInterfacesAndSelfTo<GreenCube>().FromInstance(model).AsSingle().NonLazy();

        _greenCubePresenter = new CubePresenter(model, _greenCubeView);
        _greenCubeMovementBroadcaster = new MovementBroadcaster(_input.GreenCube.Move, model);
    }
}