#include "il2cpp-config.h"

#if IL2CPP_TARGET_DARWIN

#include <sys/types.h>
#if !IL2CPP_TARGET_IOS
#include <libproc.h>
#endif
#include <unistd.h>
#include <stdlib.h>

#include "os/Process.h"
#include "vm/Exception.h"
#include "il2cpp-vm-support.h"

struct ProcessHandle
{
    pid_t pid;
};

namespace il2cpp
{
namespace os
{
    int Process::GetCurrentProcessId()
    {
        return getpid();
    }

    ProcessHandle* Process::GetProcess(int processId)
    {
        // If/when we implement the CreateProcess_internal icall we will likely
        // need to so something smarter here to find the process if we did
        // not create it and return a known pseudo-handle. For now this
        // is sufficient though.
        return (ProcessHandle*)(intptr_t)processId;
    }

    void Process::FreeProcess(ProcessHandle* handle)
    {
        // We have nothing to do here.
    }

    std::string Process::GetProcessName(ProcessHandle* handle)
    {
#if !IL2CPP_TARGET_IOS
        const size_t bufferLength = 256;
        char buf[bufferLength];
        int length = proc_name((int)((intptr_t)handle), buf, bufferLength);

        if (length <= 0)
            return std::string();

        return std::string(buf, length);
#else
        IL2CPP_VM_NOT_SUPPORTED(Process::GetProcessName, "GetProcessName is not supported for non-Windows/OSX desktop platforms");
        return std::string();
#endif
    }
}
}

#endif
