class Banner
{
public:
    //using initializers for member variables
    Banner(float w = 20, float h = 5) : width(w), height(h)
    {
    }

    void Resize(float w, float h)
    {
        width = w;
        height = h;
    }

    //a member function declared with virtual keyword supports
    //dynamic binding(dispatch) so that it can be overridden
    //in the derived class, in dynamic binding a call to a 
    //member function on an instance is indirected through
    //the class-specific v-table addressed by that instance
    virtual double Area() const
    {
        return width * height;
    }

    //Presence of a virtual destructor indicates that the
    //class is safe for inheritance
    virtual ~Banner(){}
private:
    float width, height;
};


//Specialization - is type of inheritance (is a relationship) in which 
//the derived class defines additional members not present in base class
//which itself supports activation
class CurvedBanner : public Banner //CurvedBanner is a derived class of Banner (base class),
{
public:
    //derived class constructor must call base class constructor
    //in its initializer to properly initialize the base class
    //subobject enclosed witin the instance of derived class
    CurvedBanner(float w, float h, float r) : Banner(w, h), radius(r)
    {
    }

    //function overriding - defining a member function whose declaration
    //matches with the declaration of a virtual function in the base class
    double Area() const
    {
        return Banner::Area() - 0.86 * radius * radius;
    }
private:
    float radius;
};
