//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PostComment
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Runtime.Serialization;

    public partial class Post
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Post()
        {
            this.Comments = new HashSet<Comment>();
        }

        [DataMember]
        public int PostId { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Domain { get; set; }
        [DataMember]
        public System.DateTime Date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", 
            "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public virtual ICollection<Comment> Comments { get; set; }

        public bool AddPost()
        {
            using (ModelPostCommentContainer ctx = new ModelPostCommentContainer())
            {
                bool bResult = false;
                if (this.PostId == 0)
                {
                    var it = ctx.Entry<Post>(this).State = EntityState.Added;
                    ctx.SaveChanges();
                    bResult = true;
                }
                return bResult;
            }
        }

        public Post UpdatePost(Post newPost)
        {
            using (ModelPostCommentContainer ctx = new ModelPostCommentContainer())
            {
                Post oldPost = ctx.Posts.Find(newPost.PostId);
                if (oldPost == null) // nu exista in bd
                {
                    return null;
                }
                oldPost.Description = newPost.Description;
                oldPost.Domain = newPost.Domain;
                oldPost.Date = newPost.Date;
                ctx.SaveChanges();
                return oldPost;
            }
        }
        public int DeletePost(int id)
        {
            using (ModelPostCommentContainer ctx = new ModelPostCommentContainer())
            {
                return ctx.Database.ExecuteSqlCommand("Delete From Post where postid = @p0", id);
            }
        }
        public Post GetPostById(int id)
        {
            using (ModelPostCommentContainer ctx = new ModelPostCommentContainer())
            {
                var items = from p in ctx.Posts where (p.PostId == id) select p;
                if (items != null)
                    return items.Include(c => c.Comments).SingleOrDefault();
                return null; // trebuie verificat in apelant
            }
        }
        public List<Post> GetAllPosts()
        {
            using (ModelPostCommentContainer ctx = new ModelPostCommentContainer())
            {
                return ctx.Posts.Include("Comments").ToList<Post>();
                // Obligatoriu de verificat in apelant rezultatul primit.
            }
        }
    }
}
