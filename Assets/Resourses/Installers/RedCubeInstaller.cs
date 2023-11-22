using UnityEngine;
using Zenject;

public class RedCubeInstaller : MonoInstaller
{
    [SerializeField] private CubeView _redCubeViewTemplate;

    [SerializeField] private Transform _spawnPoint;
    [SerializeField] [Range(0, 15)] private float _cubeSpeed;

    [Inject] private PlayerInput _input;

    private CubeView _redCubeView;
    private CubePresenter _redCubePresenter;

    private MovementBroadcaster _redCubeMovementBroadcaster;

    public override void InstallBindings()
    {
        var position = _spawnPoint.position;

        _redCubeView = Container.InstantiatePrefabForComponent<CubeView>(_redCubeViewTemplate, position,
            Quaternion.identity,
            null);

        var spawnContext = new CubeSpawnContext(position, _cubeSpeed);

        var model = new RedCube(spawnContext);

        Container.BindInterfacesAndSelfTo<RedCube>().FromInstance(model).AsSingle();

        _redCubePresenter = new CubePresenter(model, _redCubeView);
        _redCubeMovementBroadcaster = new MovementBroadcaster(_input.RedCube.Move, model);
    }
}