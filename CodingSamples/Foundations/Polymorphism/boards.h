
//Namespace - is a named scope for grouping related symbols
//(like functions and classes) to avoid collisions between
//their names and names of other symbols not belonging to
//their group. A symbol S defined in namespace N is referred
//by its qualified name of N::S but in the scope of N or a scope
//that imports N (with using namespace N statement) it can be 
//referred by its unqualified name of S if there is no conflict.
namespace Ads
{
    enum Substance {Plastic = 1, Wood = 2, Metal = 5};

    //Abstract Data Type (ADT) - is a class with at least one
    //pure virtual member function, such a class cannot be
    //instantiated but it can be used as a base class and as
    //a type for a pointer or a reference 
    class Signboard
    {
    public:
        //pure virtual member function - is defined without any specific
        //implimentation and with zero assignment syntax to indicate
        //that its v-table slot will contain a logical zero
        virtual double Area() const = 0;
        double Price() const;
        virtual ~Signboard() {}
    protected: //members in this access control block are visible to derived classes
        Substance material;
    };

    class Wasteful
    {
    public:
        virtual double Loss() const = 0;
        virtual ~Wasteful(){}
    protected:
        float scrap;
    };

    //Generalization - is type of inheritance (is-a relationship) in which 
    //the derived class implements pure members of base class which itself 
    //does not support activation
    class RectangularBoard : public virtual Signboard
    {
    public:
        RectangularBoard(float width, float height, Substance medium);
        double Area() const;
    private:
        float length, breadth;
    };

    //Multiple-Inheritance (MI) - a derived class directly inherits
    //from more than one other class
    //Virtual Inheritance (VI) - a class with a virtual base shares
    //the subobject of this base within the instance of its own derived
    //class which is derived from other classes with same virtual base 
    class CircularBoard : public virtual Signboard, public Wasteful
    {
    public:
        CircularBoard(float diameter, Substance medium);
        double Area() const;
        double Loss() const;
    private:
        float radius;
    };
}
