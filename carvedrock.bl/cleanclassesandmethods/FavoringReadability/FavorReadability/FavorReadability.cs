
namespace carvedrock.bl.CleanClassesAndMethods.FavoringReadability.FavorReadability
{
    public class FavorReadability
    {
        public string RateTrail(decimal len, decimal ele, string traffic, string type)
        {
            if (len > 0)
            {
                if (ele >= 0)
                {
                    if (traffic != null)
                    {
                        if (type != null)
                        {
                            if (len > 20 || ele > 400)
                            {
                                return "hard";
                            }
                            else if (10 < len && len < 20 || 100 < ele && ele < 400)
                            {
                                if (traffic == "heavy")
                                {
                                    return "hard";
                                }
                                else
                                {
                                    return "moderate";
                                }
                            }
                            else
                            {
                                return "easy";
                            }
                        }
                        else
                        {
                            throw new TrailException("type cannot be null");
                        }
                    }
                    else
                    {
                        throw new TrailException("traffic cannot be null");
                    }
                }
                else
                {
                    throw new TrailException("ele cannot be null");
                }
            }
            else
            {
                throw new TrailException("len cannot be null");
            }
        }
    }
}
