using Android.App;
using Android.Widget;
using Android.OS;
using Com.Lilarcor.Cheeseknife;

namespace FoosBall_TOP
{
    [Activity(Label = "FoosBall_TOP", MainLauncher = true)]
    public class MainActivity : Activity
    {

        [InjectView(Resource.Id.game_video)] VideoView gameVideoView;
        [InjectView(Resource.Id.blue_team)] TextView blueTeamTextView;
        [InjectView(Resource.Id.red_team)] TextView redTeamTextView;
        [InjectView(Resource.Id.event_log)] TextView eventLogTextView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);
            Cheeseknife.Inject(this);
            loadVideo();
        }

        public void loadVideo()
        {
            gameVideoView.SetVideoPath("http://techslides.com/demos/sample-videos/small.mp4");
            gameVideoView.Start();
        }
    }
}

