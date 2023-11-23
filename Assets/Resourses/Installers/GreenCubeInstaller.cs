using UnityEngine;
using Zenject;

public class GreenCubeInstaller : MonoInstaller
{
    [SerializeField] private CubeView _greenCubeViewTemplate;

    [SerializeField] private Transform _spawnPoint;
    [SerializeField] [Range(0, 15)] private float _cubeSpeed;

    [Inject] private PlayerInput _input;

    private readonly string _id = InjectionIDs.GreenCubeId;

    private CubeView _greenCubeView;
    private CubePresenter _greenCubePresenter;

    private PlayerInputBroadcaster _greenCubePlayerInputBroadcaster;

    public override void InstallBindings()
    {
        var position = _spawnPoint.position;

        _greenCubeView = Container.InstantiatePrefabForComponent<CubeView>(_greenCubeViewTemplate, position,
            Quaternion.identity,
            null);

        var spawnContext = new SpawnContext(position, _cubeSpeed);

        var model = new GreenCube(spawnContext);

        Container.Bind<IMovable>().WithId(_id).To<Cube>().FromInstance(model);

        _greenCubePresenter = new CubePresenter(model, _greenCubeView);
        _greenCubePlayerInputBroadcaster = new PlayerInputBroadcaster(_input.GreenCube.Move, model);
    }
}