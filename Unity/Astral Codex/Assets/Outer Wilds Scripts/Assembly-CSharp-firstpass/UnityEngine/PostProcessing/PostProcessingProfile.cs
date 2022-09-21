using UnityEngine;

namespace UnityEngine.PostProcessing
{
	public class PostProcessingProfile : ScriptableObject
	{
		public BuiltinDebugViewsModel debugViews;
		public FogModel fog;
		public AntialiasingModel antialiasing;
		public AmbientOcclusionModel ambientOcclusion;
		public ScreenSpaceReflectionModel screenSpaceReflection;
		public DepthOfFieldModel depthOfField;
		public MotionBlurModel motionBlur;
		public EyeAdaptationModel eyeAdaptation;
		public BloomModel bloom;
		public ColorGradingModel colorGrading;
		public UserLutModel userLut;
		public ChromaticAberrationModel chromaticAberration;
		public GrainModel grain;
		public VignetteModel vignette;
		public DitheringModel dithering;
		public CustomGammaModel customGamma;
		public EyeMaskModel eyeMask;
		public PhospheneModel phosphenes;
		public VolumeOcclusionModel volumeOcclusion;
	}
}
