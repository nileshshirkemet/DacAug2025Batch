enum Geometry {Rectangular, Triangular, Hexagonal, Elliptical};

class Banner
{
public:

    Banner()
    {
        width = 20;
        height = 8;
        shape = Geometry::Rectangular;
    }

    void Resize(float w, float h) 
    {
        width = w;
        height = h;
    }

    void Reshape(bool t)
    {
        shape = t ? Geometry::Triangular : Geometry::Rectangular;
    }

    //overloading Reshape member function
    void Reshape(Geometry g)
    {
        shape = g;
    }

    double Area() const
    {
        double region = width * height;
        float part = 0;
        switch(shape)
        {
            case Geometry::Triangular:
                part = 0.5;
                break;
            case Geometry::Hexagonal:
                part = 0.75;
                break;
            case Geometry::Elliptical:
                part = 3.14 / 4;
                break;
            default:
                part = 1;
        }
        return part * region;
    }

private: 
    float width, height;
    Geometry shape;
};
