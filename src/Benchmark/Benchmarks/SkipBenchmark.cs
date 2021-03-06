﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark.Benchmarks
{
    using System.Collections.ObjectModel;

    using BenchmarkDotNet.Attributes;

    // TODO: Record results

    /// <summary>
    /// BCL only uses IEnumerable
    /// FastLinq uses ICollection and IList
    /// </summary>
    public class SkipBenchmark
    {
        [Params(true, false)] public bool EnumerateAfterwards;
        [Params(0, 10, 100)] public int SizeOfInput;
        [Params(0, 10, 100)] public int SkipCount;

        private int[] array;
        private List<int> list;
        // HashSet is ICollection, not IList, and has a struct enumerator
        private HashSet<int> collection;
        // ReadOnlyCollection is IList, but has an object enumerator
        private ReadOnlyCollection<int> ilist;
        private IEnumerable<int> enumerable;

        [GlobalSetup]
        public void Setup()
        {
            this.enumerable = Enumerable.Range(0, this.SizeOfInput);
            this.array = enumerable.ToArray();
            this.list = enumerable.ToList();
            this.collection = new HashSet<int>(this.list);
            this.ilist = new ReadOnlyCollection<int>(this.list);
        }

        [Benchmark]
        [BenchmarkCategory("System", "Enumerable")]
        public void Enumerable_System()
        {
            var result = Enumerable.Skip(this.enumerable, this.SkipCount);
            if (this.EnumerateAfterwards)
            {
                foreach (var item in result) ;
            }
        }

        [Benchmark]
        [BenchmarkCategory("System", "Collection")]
        public void Collection_System()
        {
            var result = Enumerable.Skip(this.collection, this.SkipCount);
            if (this.EnumerateAfterwards)
            {
                foreach (var item in result) ;
            }
        }

        [Benchmark]
        [BenchmarkCategory("System", "IList")]
        public void IList_System()
        {
            var result = Enumerable.Skip(this.ilist, this.SkipCount);
            if (this.EnumerateAfterwards)
            {
                foreach (var item in result) ;
            }
        }

        [Benchmark]
        [BenchmarkCategory("System", "List")]
        public void List_System()
        {
            var result = Enumerable.Skip(this.list, this.SkipCount);
            if (this.EnumerateAfterwards)
            {
                foreach (var item in result) ;
            }
        }

        [Benchmark]
        [BenchmarkCategory("System", "Array")]
        public void Array_System()
        {
            var result = Enumerable.Skip(this.array, this.SkipCount);
            if (this.EnumerateAfterwards)
            {
                foreach (var item in result) ;
            }
        }





        // Enumerable not implemented by FastLinq
        //[Benchmark]
        //[BenchmarkCategory("FastLinq", "Enumerable")]
        //public void Enumerable_FastLinq()
        //{
        //    var result = FastLinq.Skip(this.enumerable, this.SkipCount);
        //    if (this.EnumerateAfterwards)
        //    {
        //        foreach (var item in result) ;
        //    }
        //}

        [Benchmark]
        [BenchmarkCategory("FastLinq", "Collection")]
        public void Collection_FastLinq()
        {
            var result = FastLinq.Skip(this.collection, this.SkipCount);
            if (this.EnumerateAfterwards)
            {
                foreach (var item in result) ;
            }
        }

        [Benchmark]
        [BenchmarkCategory("FastLinq", "IList")]
        public void IList_FastLinq()
        {
            var result = FastLinq.Skip(this.ilist, this.SkipCount);
            if (this.EnumerateAfterwards)
            {
                foreach (var item in result) ;
            }
        }

        [Benchmark]
        [BenchmarkCategory("FastLinq", "List")]
        public void List_FastLinq()
        {
            var result = FastLinq.Skip(this.list, this.SkipCount);
            if (this.EnumerateAfterwards)
            {
                foreach (var item in result) ;
            }
        }

        [Benchmark]
        [BenchmarkCategory("FastLinq", "Array")]
        public void Array_FastLinq()
        {
            var result = FastLinq.Skip(this.array, this.SkipCount);
            if (this.EnumerateAfterwards)
            {
                foreach (var item in result) ;
            }
        }



        
        [Benchmark]
        [BenchmarkCategory("Optimal", "Enumerable")]
        public void Enumerable_Optimal()
        {
            throw new NotImplementedException("See System for results");
        }

        [Benchmark]
        [BenchmarkCategory("Optimal", "Collection")]
        public void Collection_Optimal()
        {
            // TODO:
            throw new NotImplementedException("It's Sunday, I don't feel like implementing this right now");
        }

        [Benchmark]
        [BenchmarkCategory("Optimal", "IList")]
        public void IList_Optimal()
        {
            if (this.EnumerateAfterwards)
            {
                for (int i = this.SkipCount; i < this.SizeOfInput; i++)
                {
                    var item = this.ilist[i];
                }
            }
        }

        [Benchmark]
        [BenchmarkCategory("Optimal", "List")]
        public void List_Optimal()
        {
            if (this.EnumerateAfterwards)
            {
                for (int i = this.SkipCount; i < this.SizeOfInput; i++)
                {
                    var item = this.list[i];
                }
            }
        }

        [Benchmark]
        [BenchmarkCategory("Optimal", "Array")]
        public void Array_Optimal()
        {
            if (this.EnumerateAfterwards)
            {
                for (int i = this.SkipCount; i < this.SizeOfInput; i++)
                {
                    var item = this.array[i];
                }
            }
        }
    }
}
