using UnityEngine.PostProcessing;

public class PostProcessingGameplaySettings
{
	public PostProcessingGameplaySettings(PostProcessingBehaviour postProcessing)
	{
	}

	public bool antialiasingAvailable;
	public bool ambientOcclusionAvailable;
	public bool screenSpaceReflectionAvailable;
	public bool bloomEnabled;
	public BloomModel.BloomSettings bloom;
	public BloomModel.LensDirtSettings lensDirt;
	public BloomModel.FrostSettings frost;
	public BloomModel.BreathFogSettings breathFog;
	public bool colorGradingEnabled;
	public ColorGradingModel.BasicSettings colorGrading;
	public bool userLutEnabled;
	public UserLutModel.Settings userLut;
	public bool chromaticAberrationEnabled;
	public ChromaticAberrationModel.Settings chromaticAberration;
	public bool vignetteEnabled;
	public VignetteModel.Settings vignette;
	public bool ditheringAvailable;
	public bool customGammaAvailable;
	public bool eyeMaskEnabled;
	public EyeMaskModel.Settings eyeMask;
	public bool phosphenesEnabled;
	public PhospheneModel.Settings phosphenes;
	public bool volumeOcclusionAvailable;
}
