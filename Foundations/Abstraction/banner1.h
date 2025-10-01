class Banner
{
public: //members declared in this access-control block are visible outside of this class

    //constructor - a member function defined without any return type
    //and a name matching with the name of the class, to activate a 
    //new instance of a class its constructor must be called explicitly
    //if it has a non-optional parameter(no default argument) otherwise
    //it is called implicitly, such default constructor is automatically
    //supported by a class which does not define any constructor
    Banner()
    {
        width = 20;
        height = 8;
        triangular = false;
    }

    void Resize(float w, float h) 
    {
        width = w;
        height = h;
    }
    /*
    void Banner::Resize(Banner* this, float w, float h)
    {
        this[0].width = w;
        this[0].height = h;
    }
    */

    void Reshape(bool t)
    {
        triangular = t;
    }

    //a const member function does not mutate the state
    //of the object on which it is called
    double Area() const
    {
        double region = width * height;
        float part = triangular ? 0.5 : 1.0;
        return part * region;
    }
    /*
    double Banner::Area(const Banner* this)
    {
        double region = this[0].width * this[0].height;
        float part = this[0].triangular ? 0.5 : 1.0;
        return part * region;
    }
    */

private: //members declared in this access-control block are visible only in this class
    //instance fields - member variables whose values are separately
    //stored in instance of the class
    float width, height;
    bool triangular;
};
